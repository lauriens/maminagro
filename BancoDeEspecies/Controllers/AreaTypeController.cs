using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaTypeController : ControllerBase
    {
        private readonly ILogger<AreaTypeController> _logger;
        private readonly IAreaTypeService _AreaTypeService;

        public AreaTypeController(ILogger<AreaTypeController> logger, IAreaTypeService AreaTypeService)
        {
            _logger = logger;
            _AreaTypeService = AreaTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "AreaTypes");

            var response = await _AreaTypeService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "AreaTypes");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "AreaType");

            var response = await _AreaTypeService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "AreaType");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] AreaTypeViewModel AreaType)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "AreaType");

            await _AreaTypeService.CreateAsync(AreaType);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "AreaType");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "AreaType");

            await _AreaTypeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "AreaType");

            return NoContent();
        }
    }
}
