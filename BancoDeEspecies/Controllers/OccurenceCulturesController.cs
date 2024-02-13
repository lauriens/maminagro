using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.OccurrenceCulture;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccurrenceCultureController : ControllerBase
    {
        private readonly ILogger<OccurrenceCultureController> _logger;
        private readonly IOccurrenceCultureService _OccurrenceCultureService;

        public OccurrenceCultureController(ILogger<OccurrenceCultureController> logger, IOccurrenceCultureService OccurrenceCultureService)
        {
            _logger = logger;
            _OccurrenceCultureService = OccurrenceCultureService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "OccurrenceCultures");

            var response = await _OccurrenceCultureService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "OccurrenceCultures");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "OccurrenceCulture");

            var response = await _OccurrenceCultureService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "OccurrenceCulture");

            return Ok(response);
        }

        [HttpGet("byOccurrenceOrCulture")]
        public async Task<IActionResult> GetFilteredOccurrenceCulturesAsync([FromQuery] int? cultureId, [FromQuery] int? occurrenceId)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetFilteredOccurrenceCulturesAsync", "OccurrenceCulture");

            var response = await _OccurrenceCultureService.GetFilteredOccurrenceCultures(cultureId, occurrenceId);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetFilteredOccurrenceCulturesAsync", "OccurrenceCulture");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateOccurrenceCultureViewModel occurrenceCulture)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "OccurrenceCulture");

            await _OccurrenceCultureService.CreateAsync(occurrenceCulture);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "OccurrenceCulture");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "OccurrenceCulture");

            await _OccurrenceCultureService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "OccurrenceCulture");

            return NoContent();
        }
    }
}
