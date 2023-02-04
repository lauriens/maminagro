using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UfController : ControllerBase
    {
        private readonly ILogger<UfController> _logger;
        private readonly IUfService _UfService;

        public UfController(ILogger<UfController> logger, IUfService UfService)
        {
            _logger = logger;
            _UfService = UfService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Ufs");

            var response = await _UfService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Ufs");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "Uf");

            var response = await _UfService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "Uf");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UfViewModel uf)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "Uf");

            await _UfService.CreateAsync(uf);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "Uf");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "Uf");

            await _UfService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "Uf");

            return NoContent();
        }
    }
}
