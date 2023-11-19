using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.LandscapeLocality;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandscapeLocalityController : ControllerBase
    {
        private readonly ILogger<LandscapeLocalityController> _logger;
        private readonly ILandscapeLocalityService _LandscapeLocalityService;

        public LandscapeLocalityController(ILogger<LandscapeLocalityController> logger, ILandscapeLocalityService LandscapeLocalityService)
        {
            _logger = logger;
            _LandscapeLocalityService = LandscapeLocalityService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateLandscapeLocalityViewModel LandscapeLocality)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "LandscapeLocality");

            await _LandscapeLocalityService.CreateAsync(LandscapeLocality);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "LandscapeLocality");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("{landscapeId}/{localityId}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int landscapeId, [FromRoute] int localityId)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "LandscapeLocality");

            await _LandscapeLocalityService.DeleteAsync(landscapeId, localityId);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "LandscapeLocality");

            return NoContent();
        }
    }
}
