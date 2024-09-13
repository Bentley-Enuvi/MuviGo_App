namespace MuviGo.Infrastructure.CosmosData.Interfaces
{
    public interface ICosmosDb
    {
        Task AddItemAsync<T>(T item, string containerName);
        Task DeleteItemAsync<T>(string id, string containerName);
        Task<T> GetItemAsync<T>(string id, string containerName);
        Task<IEnumerable<T>> GetItemsAsync<T>(string queryString, string containerName);
        Task UpdateItemAsync<T>(string id, T item, string containerName);
    }
}