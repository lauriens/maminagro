using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Specie;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecieController : ControllerBase
    {
        private readonly ILogger<SpecieController> _logger;
        private readonly ISpeciesService _SpeciesService;

        public SpecieController(ILogger<SpecieController> logger, ISpeciesService SpeciesService)
        {
            _logger = logger;
            _SpeciesService = SpeciesService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Species");

            var response = await _SpeciesService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Species");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Specie");

            var response = await _SpeciesService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Specie");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateSpecieViewModel specie)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Specie");

            await _SpeciesService.CreateAsync(specie);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Specie");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Specie");

            await _SpeciesService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Specie");

            return NoContent();
        }
    }
}
