using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationTypesController : ControllerBase
    {
        private readonly ILogger<LocationTypesController> _logger;
        private readonly ILocationTypeService _LocationTypeService;

        public LocationTypesController(ILogger<LocationTypesController> logger, ILocationTypeService LocationTypeService)
        {
            _logger = logger;
            _LocationTypeService = LocationTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "LocationTypes");

            var response = await _LocationTypeService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "LocationTypes");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "LocationType");

            var response = await _LocationTypeService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "LocationType");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] LocationTypeViewModel LocationType)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "LocationType");

            await _LocationTypeService.CreateAsync(LocationType);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "LocationType");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "LocationType");

            await _LocationTypeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "LocationType");

            return NoContent();
        }
    }
}
