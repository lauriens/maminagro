using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.MaterialDestination;
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

        [HttpGet("list")]
        public async Task<IActionResult> GetList()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetList", "MaterialDestination");

            var response = await _MaterialDestinationService.GetMaterialDestinationListAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetList", "MaterialDestination");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateMaterialDestinationViewModel materialDestination)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "MaterialDestination");

            await _MaterialDestinationService.CreateAsync(materialDestination);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "MaterialDestination");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "MaterialDestination");

            await _MaterialDestinationService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "MaterialDestination");

            return NoContent();
        }
    }
}
