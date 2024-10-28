using AutoMapper;
using Db_Watch_and_Ring.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using MyAPI.Model;

namespace MyAPI.Repository
{
    public class DongHorepository : IWatchRepository
    {
        private readonly WatchDbContext _db;
        private readonly IMapper _mapper;

        public DongHorepository(WatchDbContext db , IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<WatchModel> CreateWatchAsync(WatchModel ho)
        {
            var newWatch = _mapper.Map<DongHo>(ho);
            _db.DongHos.Add(newWatch);
            await _db.SaveChangesAsync();
            var newWatchModel = _mapper.Map<WatchModel>(newWatch);
            return newWatchModel;
        }

        public async Task DeleteWatchAsync(Guid id)
        {
            var deleteWatch = _db.DongHos.SingleOrDefault(x => x.ID == id);

            if(deleteWatch != null)
            {
                _db.DongHos.Remove(deleteWatch);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<List<WatchModel>> GetAllWatchAsync()
        {
            var w = await _db.DongHos.ToListAsync();
            return _mapper.Map<List<WatchModel>>(w);
        }

        public async Task<WatchModel> GetWatchByIdAsync(Guid id)
        {
            var w1 = await _db.DongHos.FindAsync(id);
            return _mapper.Map<WatchModel>(w1);
        }

        public async Task<WatchModel> UpdateWatchAsync(Guid id,WatchModel model)
        {
            var existingWatch = await _db.DongHos.FindAsync(id);
            if (existingWatch == null)
            {
                return null!; 
            }

            existingWatch.ID = model.ID;
            existingWatch.Name = model.Name;
            existingWatch.NamRaDoi = model.NamRaDoi;
            existingWatch.MoTa = model.MoTa;
            existingWatch.LoaiMayID = model.LoaiMayID;
            existingWatch.MatKinhID = model.MatKinhID;

            _db.DongHos.Update(existingWatch);
            await _db.SaveChangesAsync();

            return _mapper.Map<WatchModel>(existingWatch);
        }
    }
}
