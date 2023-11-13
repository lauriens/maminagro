using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.LandscapeMunicipality;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandscapeMunicipalityController : ControllerBase
    {
        private readonly ILogger<LandscapeMunicipalityController> _logger;
        private readonly ILandscapeMunicipalityService _LandscapeMunicipalityService;

        public LandscapeMunicipalityController(ILogger<LandscapeMunicipalityController> logger, ILandscapeMunicipalityService LandscapeMunicipalityService)
        {
            _logger = logger;
            _LandscapeMunicipalityService = LandscapeMunicipalityService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateLandscapeMunicipalityViewModel LandscapeMunicipality)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "LandscapeMunicipality");

            await _LandscapeMunicipalityService.CreateAsync(LandscapeMunicipality);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "LandscapeMunicipality");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "LandscapeMunicipality");

            await _LandscapeMunicipalityService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "LandscapeMunicipality");

            return NoContent();
        }
    }
}
