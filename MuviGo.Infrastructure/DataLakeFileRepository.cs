using Azure.Storage.Files.DataLake;
using MuviGo.Domain.Models;
using MuviGo.Infrastructure.CosmosData.Interfaces;

namespace MuviGo.Infrastructure
{
    public class DataLakeFileRepository : IFileRepository<FileBluePrint>
    {
        private readonly DataLakeFileSystemClient _fileSystemClient;

        public DataLakeFileRepository(string connectionString, string fileSystemName)
        {
            var serviceClient = new DataLakeServiceClient(connectionString);
            _fileSystemClient = serviceClient.GetFileSystemClient(fileSystemName);
        }

        public async Task<bool> DeleteFileAsync(string fileId)
        {
            var fileClient = _fileSystemClient.GetFileClient(fileId);
            await fileClient.DeleteAsync();
            return true;
        }

        public async Task<Stream> DownloadFileAsync(string fileId)
        {
            var fileClient = _fileSystemClient.GetFileClient(fileId);
            var response = await fileClient.ReadAsync();
            return response.Value.Content;
        }

        public async Task<IEnumerable<FileBluePrint>> GetFilesAsync()
        {
            var files = new List<FileBluePrint>();
            await foreach (var pathItem in _fileSystemClient.GetPathsAsync())
            {
                files.Add(new FileBluePrint
                {
                    id = pathItem.Name,
                    FileName = pathItem.Name,
                    FileUrl = _fileSystemClient.GetFileClient(pathItem.Name).Uri.AbsoluteUri
                });
            }
            return files;
        }

        public async Task<FileBluePrint> UploadFileAsync(Stream fileStream, string fileName)
        {
            try
            {
                var fileClient = _fileSystemClient.GetFileClient(fileName);

                // Ensure the file stream is at the start
                fileStream.Position = 0;

                // Upload the file stream, overwriting if it already exists
                await fileClient.UploadAsync(fileStream, overwrite: true);

                // Retrieve file properties to set the correct file details
                var properties = await fileClient.GetPropertiesAsync();

                return new FileBluePrint
                {
                    id = fileClient.Path,
                    FileName = fileClient.Name,
                    FileUrl = fileClient.Uri.AbsoluteUri,
                    FileSize = properties.Value.ContentLength,
                    ContentType = properties.Value.ContentType
                };
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                Console.WriteLine($"Error uploading file to Azure Data Lake: {ex.Message}");
                throw;
            }
        }

    }
}
