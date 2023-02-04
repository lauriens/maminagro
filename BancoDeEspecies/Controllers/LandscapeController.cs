using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandscapeController : ControllerBase
    {
        private readonly ILogger<LandscapeController> _logger;
        private readonly ILandscapeService _LandscapeService;

        public LandscapeController(ILogger<LandscapeController> logger, ILandscapeService LandscapeService)
        {
            _logger = logger;
            _LandscapeService = LandscapeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Landscapes");

            var response = await _LandscapeService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Landscapes");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Landscape");

            var response = await _LandscapeService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Landscape");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] LandscapeViewModel Landscape)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Landscape");

            await _LandscapeService.CreateAsync(Landscape);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Landscape");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Landscape");

            await _LandscapeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Landscape");

            return NoContent();
        }
    }
}
