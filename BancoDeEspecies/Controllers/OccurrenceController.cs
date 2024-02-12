using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Occurrence;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccurrencesController : ControllerBase
    {
        private readonly ILogger<OccurrencesController> _logger;
        private readonly IOccurrenceService _OccurrenceService;

        public OccurrencesController(ILogger<OccurrencesController> logger, IOccurrenceService OccurrenceService)
        {
            _logger = logger;
            _OccurrenceService = OccurrenceService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Occurrences");

            var response = await _OccurrenceService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Occurrences");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Occurrence");

            var response = await _OccurrenceService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Occurrence");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateOccurrenceViewModel occurrence)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Occurrence");

            var response = await _OccurrenceService.CreateAsync(occurrence);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Occurrence");

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Occurrence");

            await _OccurrenceService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Occurrence");

            return NoContent();
        }
    }
}
