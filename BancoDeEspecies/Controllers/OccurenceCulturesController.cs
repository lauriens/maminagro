using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccurrenceCulturesController : ControllerBase
    {
        private readonly ILogger<OccurrenceCulturesController> _logger;
        private readonly IOccurrenceCultureService _OccurrenceCultureService;

        public OccurrenceCulturesController(ILogger<OccurrenceCulturesController> logger, IOccurrenceCultureService OccurrenceCultureService)
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

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] OccurrenceCultureViewModel OccurrenceCulture)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "OccurrenceCulture");

            await _OccurrenceCultureService.CreateAsync(OccurrenceCulture);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "OccurrenceCulture");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "OccurrenceCulture");

            await _OccurrenceCultureService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "OccurrenceCulture");

            return NoContent();
        }
    }
}
