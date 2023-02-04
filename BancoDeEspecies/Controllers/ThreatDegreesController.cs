using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThreatDegreesController : ControllerBase
    {
        private readonly ILogger<ThreatDegreesController> _logger;
        private readonly IThreatDegreeService _ThreatDegreeService;

        public ThreatDegreesController(ILogger<ThreatDegreesController> logger, IThreatDegreeService ThreatDegreeService)
        {
            _logger = logger;
            _ThreatDegreeService = ThreatDegreeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "ThreatDegrees");

            var response = await _ThreatDegreeService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "ThreatDegrees");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "ThreatDegree");

            var response = await _ThreatDegreeService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "ThreatDegree");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ThreatDegreeViewModel ThreatDegree)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "ThreatDegree");

            await _ThreatDegreeService.CreateAsync(ThreatDegree);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "ThreatDegree");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "ThreatDegree");

            await _ThreatDegreeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "ThreatDegree");

            return NoContent();
        }
    }
}
