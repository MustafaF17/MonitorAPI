using MonitorApplication.Model;

namespace MonitorApplication.Repository.Interface
{
    public interface IMonitorRepository
    {
        Task<bool> CreateMetaData(MetaData metaData);
        Task<MetaData> GetMetaDataById(Guid id);
        Task<List<MetaData>> GetAllMetaData();
        Task<bool> Save();
    }
}
