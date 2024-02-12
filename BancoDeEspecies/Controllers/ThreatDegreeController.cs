using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.ThreatDegree;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThreatDegreeController : ControllerBase
    {
        private readonly ILogger<ThreatDegreeController> _logger;
        private readonly IThreatDegreeService _ThreatDegreeService;

        public ThreatDegreeController(ILogger<ThreatDegreeController> logger, IThreatDegreeService ThreatDegreeService)
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

        [HttpGet("specie/{specieId}")]
        public async Task<IActionResult> GetBySpecieIdAsync([FromRoute] int specieId)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetBySpecieId", "ThreatDegree");

            var response = await _ThreatDegreeService.GetThreatDegreesBySpecieAsync(specieId);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetBySpecieId", "ThreatDegree");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateThreatDegreeViewModel threatDegree)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "ThreatDegree");

            await _ThreatDegreeService.CreateAsync(threatDegree);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "ThreatDegree");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "ThreatDegree");

            await _ThreatDegreeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "ThreatDegree");

            return NoContent();
        }
    }
}
