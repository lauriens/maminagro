using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Phylum;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhylumController : ControllerBase
    {
        private readonly ILogger<PhylumController> _logger;
        private readonly IPhylumService _PhylaService;

        public PhylumController(ILogger<PhylumController> logger, IPhylumService PhylaService)
        {
            _logger = logger;
            _PhylaService = PhylaService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Phyla");

            var response = await _PhylaService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Phyla");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Phylum");

            var response = await _PhylaService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Phylum");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreatePhylumViewModel phylum)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Phylum");

            await _PhylaService.CreateAsync(phylum);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Phylum");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Phylum");

            await _PhylaService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Phylum");

            return NoContent();
        }
    }
}
