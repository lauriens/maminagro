using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Culture;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CultureController : ControllerBase
    {
        private readonly ILogger<CultureController> _logger;
        private readonly ICultureService _CultureService;

        public CultureController(ILogger<CultureController> logger, ICultureService CultureService)
        {
            _logger = logger;
            _CultureService = CultureService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Cultures");

            var response = await _CultureService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Cultures");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Culture");

            var response = await _CultureService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Culture");

            return Ok(response);
        }

        [HttpGet("landscape/{landscapeId}")]
        public async Task<IActionResult> GetByLandscapeIdAsync([FromRoute] int landscapeId)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetByLandscapeIdAsync", "Culture");

            var response = await _CultureService.GetLandscapeCulturesAsync(landscapeId);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetByLandscapeIdAsync", "Culture");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateCultureViewModel culture)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Culture");

            var response = await _CultureService.CreateAsync(culture);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Culture");

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Culture");

            await _CultureService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Culture");

            return NoContent();
        }
    }
}
