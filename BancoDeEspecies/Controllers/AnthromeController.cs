using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Anthrome;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnthromeController : ControllerBase
    {
        private readonly ILogger<AnthromeController> _logger;
        private readonly IAnthromeService _AnthromeService;

        public AnthromeController(ILogger<AnthromeController> logger, IAnthromeService AnthromeService)
        {
            _logger = logger;
            _AnthromeService = AnthromeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Anthromes");

            var response = await _AnthromeService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Anthromes");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Anthrome");

            var response = await _AnthromeService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Anthrome");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateAnthromeViewModel anthrome)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Anthrome");

            await _AnthromeService.CreateAsync(anthrome);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Anthrome");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Anthrome");

            await _AnthromeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Anthrome");

            return NoContent();
        }
    }
}
