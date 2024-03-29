﻿using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels.Municipality;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipalityController : Controller
    {
        private readonly ILogger<MunicipalityController> _logger;
        private readonly IMunicipalityService _CityService;

        public MunicipalityController(ILogger<MunicipalityController> logger, IMunicipalityService CityService)
        {
            _logger = logger;
            _CityService = CityService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Citys");

            var response = await _CityService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Citys");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "City");

            var response = await _CityService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "City");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateMunicipalityViewModel city)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "City");

            await _CityService.CreateAsync(city);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "City");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "City");

            await _CityService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "City");

            return NoContent();
        }
    }
}
