using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.StudyCollectMethod;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyCollectMethodController : ControllerBase
    {
        private readonly ILogger<StudyCollectMethodController> _logger;
        private readonly IStudyCollectMethodService _StudyCollectMethodService;

        public StudyCollectMethodController(ILogger<StudyCollectMethodController> logger, IStudyCollectMethodService StudyCollectMethodService)
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
        public async Task<IActionResult> CreateAsync([FromBody] CreateStudyCollectMethodViewModel studyCollectMethod)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "StudyCollectMethod");

            await _StudyCollectMethodService.CreateAsync(studyCollectMethod);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "StudyCollectMethod");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "StudyCollectMethod");

            await _StudyCollectMethodService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "StudyCollectMethod");

            return NoContent();
        }
    }
}
