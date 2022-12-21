using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitorApplication.Model;
using MonitorApplication.Repository.Interface;

namespace MonitorApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitorController : ControllerBase
    {

        private readonly IMonitorRepository _monitorRepository;

        public MonitorController(IMonitorRepository monitorRepository)
        {
            _monitorRepository = monitorRepository ?? throw new ArgumentNullException(nameof(monitorRepository));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMonitorInfo()
        {
            return Ok("Receivied Data");
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetMonitorInfo(int id)
        {
            return Ok("Receivied Data: " + id);
        }

        [HttpPost("/Metadata")]
        public async Task<IActionResult> PostMetaData(MetaData metaData)
        {
            bool created = await _monitorRepository.CreateMetaData(metaData);
            return Ok(created);
        }

        [HttpGet("/Metadata")]
        public async Task<IActionResult> GetAllMetaData()
        {
            List<MetaData> metaDatas = await _monitorRepository.GetAllMetaData();
            return Ok(metaDatas);
        }

        [HttpGet("/Metadata/{id}")]
        public async Task<IActionResult> GetMetaDataById(Guid id)
        {
            MetaData metaData = await _monitorRepository.GetMetaDataById(id);
            return Ok(metaData);
        }



    }
}
