using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenceTypesController : ControllerBase
    {
        private readonly ILogger<ReferenceTypesController> _logger;
        private readonly IReferenceTypeService _ReferenceTypeService;

        public ReferenceTypesController(ILogger<ReferenceTypesController> logger, IReferenceTypeService ReferenceTypeService)
        {
            _logger = logger;
            _ReferenceTypeService = ReferenceTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "ReferenceTypes");

            var response = await _ReferenceTypeService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "ReferenceTypes");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "ReferenceType");

            var response = await _ReferenceTypeService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "ReferenceType");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ReferenceTypeViewModel ReferenceType)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "ReferenceType");

            await _ReferenceTypeService.CreateAsync(ReferenceType);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "ReferenceType");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "ReferenceType");

            await _ReferenceTypeService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "ReferenceType");

            return NoContent();
        }
    }
}
