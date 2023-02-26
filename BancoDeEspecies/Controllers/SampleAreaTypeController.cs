using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.SampleAreaType;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleAreaTypeController : ControllerBase
    {
        private readonly ILogger<SampleAreaTypeController> _logger;
        private readonly ISampleAreaTypeService _SampleAreaTypeService;

        public SampleAreaTypeController(ILogger<SampleAreaTypeController> logger, ISampleAreaTypeService SampleAreaTypeService)
        {
            _logger = logger;
            _SampleAreaTypeService = SampleAreaTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "SampleAreaTypes");

            var response = await _SampleAreaTypeService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "SampleAreaTypes");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "SampleAreaType");

            var response = await _SampleAreaTypeService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "SampleAreaType");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateSampleAreaTypeViewModel sampleAreaType)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "SampleAreaType");

            await _SampleAreaTypeService.CreateAsync(sampleAreaType);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "SampleAreaType");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "SampleAreaType");

            await _SampleAreaTypeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "SampleAreaType");

            return NoContent();
        }
    }
}
