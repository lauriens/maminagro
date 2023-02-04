using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyCollectMethodsController : ControllerBase
    {
        private readonly ILogger<StudyCollectMethodsController> _logger;
        private readonly IStudyCollectMethodService _StudyCollectMethodService;

        public StudyCollectMethodsController(ILogger<StudyCollectMethodsController> logger, IStudyCollectMethodService StudyCollectMethodService)
        {
            _logger = logger;
            _StudyCollectMethodService = StudyCollectMethodService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "StudyCollectMethods");

            var response = await _StudyCollectMethodService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "StudyCollectMethods");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "StudyCollectMethod");

            var response = await _StudyCollectMethodService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "StudyCollectMethod");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] StudyCollectMethodViewModel StudyCollectMethod)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "StudyCollectMethod");

            await _StudyCollectMethodService.CreateAsync(StudyCollectMethod);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "StudyCollectMethod");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "StudyCollectMethod");

            await _StudyCollectMethodService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "StudyCollectMethod");

            return NoContent();
        }
    }
}
