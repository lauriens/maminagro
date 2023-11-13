using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Agroecosystem;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgroecosystemController : ControllerBase
    {
        private readonly ILogger<AgroecosystemController> _logger;
        private readonly IAgroecosystemService _AgroecosystemService;

        public AgroecosystemController(ILogger<AgroecosystemController> logger, IAgroecosystemService AgroecosystemService)
        {
            _logger = logger;
            _AgroecosystemService = AgroecosystemService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Agroecosystems");

            var response = await _AgroecosystemService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Agroecosystems");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Agroecosystem");

            var response = await _AgroecosystemService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Agroecosystem");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateAgroecosystemViewModel Agroecosystem)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Agroecosystem");

            await _AgroecosystemService.CreateAsync(Agroecosystem);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Agroecosystem");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Agroecosystem");

            await _AgroecosystemService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Agroecosystem");

            return NoContent();
        }
    }
}
