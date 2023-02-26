using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Biome;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiomeController : ControllerBase
    {
        private readonly ILogger<BiomeController> _logger;
        private readonly IBiomeService _BiomeService;

        public BiomeController(ILogger<BiomeController> logger, IBiomeService BiomeService)
        {
            _logger = logger;
            _BiomeService = BiomeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Biomes");

            var response = await _BiomeService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Biomes");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Biome");

            var response = await _BiomeService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Biome");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateBiomeViewModel biome)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Biome");

            await _BiomeService.CreateAsync(biome);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Biome");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Biome");

            await _BiomeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Biome");

            return NoContent();
        }
    }
}
