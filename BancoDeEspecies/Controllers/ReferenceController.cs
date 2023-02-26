using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Reference;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenceController : ControllerBase
    {
        private readonly ILogger<ReferenceController> _logger;
        private readonly IReferenceService _ReferenceService;

        public ReferenceController(ILogger<ReferenceController> logger, IReferenceService ReferenceService)
        {
            _logger = logger;
            _ReferenceService = ReferenceService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "References");

            var response = await _ReferenceService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "References");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Reference");

            var response = await _ReferenceService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Reference");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateReferenceViewModel reference)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Reference");

            await _ReferenceService.CreateAsync(reference);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Reference");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Reference");

            await _ReferenceService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Reference");

            return NoContent();
        }
    }
}
