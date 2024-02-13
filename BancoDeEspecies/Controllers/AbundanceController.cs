using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Abundance;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbundanceController : ControllerBase
    {
        private readonly ILogger<AbundanceController> _logger;
        private readonly IAbundanceService _AbundanceService;

        public AbundanceController(ILogger<AbundanceController> logger, IAbundanceService AbundanceService)
        {
            _logger = logger;
            _AbundanceService = AbundanceService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Abundances");

            var response = await _AbundanceService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Abundances");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Abundance");

            var response = await _AbundanceService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Abundance");

            return Ok(response);
        }

        [HttpGet("byLandscapeOrOccurrence")]
        public async Task<IActionResult> GetFilteredAbundancesAsync([FromQuery] int? landscapeId, [FromQuery] int? occurrenceId)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetFilteredAbundancesAsync", "Abundance");

            var response = await _AbundanceService.GetFilteredAbundances(occurrenceId, landscapeId);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetFilteredAbundancesAsync", "Abundance");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateAbundanceViewModel abundance)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Abundance");

            await _AbundanceService.CreateAsync(abundance);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Abundance");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Abundance");

            await _AbundanceService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Abundance");

            return NoContent();
        }
    }
}
