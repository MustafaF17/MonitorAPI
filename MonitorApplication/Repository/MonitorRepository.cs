using Microsoft.EntityFrameworkCore;
using MonitorApplication.Data;
using MonitorApplication.Model;
using MonitorApplication.Repository.Interface;

namespace MonitorApplication.Repository
{
    public class MonitorRepository : IMonitorRepository
    {

        private readonly DataContext _context;

        public MonitorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateMetaData(MetaData metaData)
        {
            _context.MetaDatas.Add(metaData);
            return await Save();
        }

        public async Task<List<MetaData>> GetAllMetaData()
        {
            return await _context.MetaDatas.ToListAsync();
        }

        public async Task<MetaData> GetMetaDataById(Guid id)
        {
            MetaData? metaData = await _context.MetaDatas.FindAsync(id);
            return metaData;
        }

        public async Task<bool> Save()
        {
            int saved = await _context.SaveChangesAsync();
            if (saved > 0) return true;
            return false;
        }
    }
}
