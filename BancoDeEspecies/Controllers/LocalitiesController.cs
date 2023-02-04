using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalitiesController : Controller
    {
        private readonly ILogger<LocalitiesController> _logger;
        private readonly ILocalityService _localitiesService;

        public LocalitiesController(ILogger<LocalitiesController> logger, ILocalityService localitiesService)
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
        public async Task<IActionResult> CreateAsync([FromBody] LocalityViewModel locality)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Locality");

            await _localitiesService.CreateAsync(locality);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Locality");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Locality");

            await _localitiesService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Locality");

            return NoContent();
        }
    }
}
