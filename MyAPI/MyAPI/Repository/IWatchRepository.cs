using Db_Watch_and_Ring.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using MyAPI.Model;

namespace MyAPI.Repository
{
    public interface IWatchRepository
    {
        public Task<List<WatchModel>> GetAllWatchAsync();
        public Task<WatchModel> GetWatchByIdAsync(Guid id);

        public Task<WatchModel> CreateWatchAsync(WatchModel ho);
        public Task<WatchModel> UpdateWatchAsync(Guid id , WatchModel ho);
        public Task DeleteWatchAsync(Guid id);
    }
}
