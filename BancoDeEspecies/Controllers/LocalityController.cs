using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Locality;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalityController : Controller
    {
        private readonly ILogger<LocalityController> _logger;
        private readonly ILocalityService _localitiesService;

        public LocalityController(ILogger<LocalityController> logger, ILocalityService localitiesService)
        {
            _logger = logger;
            _localitiesService = localitiesService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Localities");

            var response = await _localitiesService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Locality=ies");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Locality");

            var response = await _localitiesService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Locality");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateLocalityViewModel locality)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Locality");

            await _localitiesService.CreateAsync(locality);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Locality");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Locality");

            await _localitiesService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Locality");

            return NoContent();
        }
    }
}
