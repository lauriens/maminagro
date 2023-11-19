using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.LandscapeAreaType;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandscapeAreaTypeController : ControllerBase
    {
        private readonly ILogger<LandscapeAreaTypeController> _logger;
        private readonly ILandscapeAreaTypeService _LandscapeAreaTypeService;

        public LandscapeAreaTypeController(ILogger<LandscapeAreaTypeController> logger, ILandscapeAreaTypeService LandscapeAreaTypeService)
        {
            _logger = logger;
            _LandscapeAreaTypeService = LandscapeAreaTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "LandscapeAreaTypes");

            var response = await _LandscapeAreaTypeService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "LandscapeAreaTypes");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "LandscapeAreaType");

            var response = await _LandscapeAreaTypeService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "LandscapeAreaType");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateLandscapeAreaTypeViewModel landscapeAreaType)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "LandscapeAreaType");

            await _LandscapeAreaTypeService.CreateAsync(landscapeAreaType);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "LandscapeAreaType");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "LandscapeAreaType");

            await _LandscapeAreaTypeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "LandscapeAreaType");

            return NoContent();
        }
    }
}
