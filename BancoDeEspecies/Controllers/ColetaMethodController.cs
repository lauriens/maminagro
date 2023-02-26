using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.OccurrenceColetaMethod;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColetaMethodController : ControllerBase
    {
        private readonly ILogger<ColetaMethodController> _logger;
        private readonly IColetaMethodService _ColetaMethodService;

        public ColetaMethodController(ILogger<ColetaMethodController> logger, IColetaMethodService ColetaMethodService)
        {
            _logger = logger;
            _ColetaMethodService = ColetaMethodService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "ColetaMethods");

            var response = await _ColetaMethodService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "ColetaMethods");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "ColetaMethod");

            var response = await _ColetaMethodService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "ColetaMethod");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateOccurrenceColetaMethodViewModel coletaMethod)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "ColetaMethod");

            await _ColetaMethodService.CreateAsync(coletaMethod);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "ColetaMethod");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "ColetaMethod");

            await _ColetaMethodService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "ColetaMethod");

            return NoContent();
        }
    }
}
