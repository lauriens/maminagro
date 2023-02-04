using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CultureSpecieController : ControllerBase
    {
        private readonly ILogger<CultureSpecieController> _logger;
        private readonly ICultureSpecieService _CultureSpecieService;

        public CultureSpecieController(ILogger<CultureSpecieController> logger, ICultureSpecieService CultureSpecieService)
        {
            _logger = logger;
            _CultureSpecieService = CultureSpecieService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "CultureSpecies");

            var response = await _CultureSpecieService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "CultureSpecies");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "CultureSpecie");

            var response = await _CultureSpecieService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "CultureSpecie");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CultureSpecieViewModel CultureSpecie)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "CultureSpecie");

            await _CultureSpecieService.CreateAsync(CultureSpecie);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "CultureSpecie");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "CultureSpecie");

            await _CultureSpecieService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "CultureSpecie");

            return NoContent();
        }
    }
}
