using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.BiomeLandscape;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiomeLandscapeController : ControllerBase
    {
        private readonly ILogger<BiomeLandscapeController> _logger;
        private readonly IBiomeLandscapeService _BiomeLandscapeService;

        public BiomeLandscapeController(ILogger<BiomeLandscapeController> logger, IBiomeLandscapeService BiomeLandscapeService)
        {
            _logger = logger;
            _BiomeLandscapeService = BiomeLandscapeService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateBiomeLandscapeViewModel BiomeLandscape)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "BiomeLandscape");

            await _BiomeLandscapeService.CreateAsync(BiomeLandscape);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "BiomeLandscape");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("{biomeId}/{landscapeId}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int biomeId, [FromRoute] int landscapeId)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "BiomeLandscape");

            await _BiomeLandscapeService.DeleteAsync(biomeId, landscapeId);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "BiomeLandscape");

            return NoContent();
        }
    }
}
