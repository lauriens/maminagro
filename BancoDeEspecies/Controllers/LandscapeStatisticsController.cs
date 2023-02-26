using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.LandscapeStatistic;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandscapeStatisticsController : ControllerBase
    {
        private readonly ILogger<LandscapeStatisticsController> _logger;
        private readonly ILandscapeStatisticService _LandscapeStatisticService;

        public LandscapeStatisticsController(ILogger<LandscapeStatisticsController> logger, ILandscapeStatisticService LandscapeStatisticService)
        {
            _logger = logger;
            _LandscapeStatisticService = LandscapeStatisticService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "LandscapeStatistics");

            var response = await _LandscapeStatisticService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "LandscapeStatistics");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "LandscapeStatistic");

            var response = await _LandscapeStatisticService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "LandscapeStatistic");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateLandscapeStatisticViewModel landscapeStatistic)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "LandscapeStatistic");

            await _LandscapeStatisticService.CreateAsync(landscapeStatistic);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "LandscapeStatistic");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "LandscapeStatistic");

            await _LandscapeStatisticService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "LandscapeStatistic");

            return NoContent();
        }
    }
}
