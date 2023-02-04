using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialDestinationsController : ControllerBase
    {
        private readonly ILogger<MaterialDestinationsController> _logger;
        private readonly IMaterialDestinationService _MaterialDestinationService;

        public MaterialDestinationsController(ILogger<MaterialDestinationsController> logger, IMaterialDestinationService MaterialDestinationService)
        {
            _logger = logger;
            _MaterialDestinationService = MaterialDestinationService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "MaterialDestinations");

            var response = await _MaterialDestinationService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "MaterialDestinations");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "MaterialDestination");

            var response = await _MaterialDestinationService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "MaterialDestination");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] MaterialDestinationViewModel MaterialDestination)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "MaterialDestination");

            await _MaterialDestinationService.CreateAsync(MaterialDestination);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "MaterialDestination");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "MaterialDestination");

            await _MaterialDestinationService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "MaterialDestination");

            return NoContent();
        }
    }
}
