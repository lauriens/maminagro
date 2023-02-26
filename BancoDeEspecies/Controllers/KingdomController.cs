using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Kingdom;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KingdomController : ControllerBase
    {
        private readonly ILogger<KingdomController> _logger;
        private readonly IKingdomService _KingdomService;

        public KingdomController(ILogger<KingdomController> logger, IKingdomService KingdomService)
        {
            _logger = logger;
            _KingdomService = KingdomService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Kingdoms");

            var response = await _KingdomService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Kingdoms");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Kingdom");

            var response = await _KingdomService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Kingdom");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateKingdomViewModel kingdom)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Kingdom");

            await _KingdomService.CreateAsync(kingdom);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Kingdom");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Kingdom");

            await _KingdomService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Kingdom");

            return NoContent();
        }
    }
}
