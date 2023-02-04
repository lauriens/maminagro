using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenaController : ControllerBase
    {
        private readonly ILogger<GenaController> _logger;
        private readonly IGenusService _GenaService;

        public GenaController(ILogger<GenaController> logger, IGenusService GenaService)
        {
            _logger = logger;
            _GenaService = GenaService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Genas");

            var response = await _GenaService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Genas");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Gena");

            var response = await _GenaService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Gena");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] GenusViewModel Gena)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Gena");

            await _GenaService.CreateAsync(Gena);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Gena");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Gena");

            await _GenaService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Gena");

            return NoContent();
        }
    }
}
