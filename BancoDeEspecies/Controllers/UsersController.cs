﻿using BancoDeEspecies.Application.Services;
using BancoDeEspecies.Application.Utilities;
using BancoDeEspecies.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeEspecies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserService _UserService;

        public UsersController(ILogger<UsersController> logger, IUserService UserService)
        {
            _logger = logger;
            _UserService = UserService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAllAsync()
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "ListAllAsync", "Users");

            var response = await _UserService.GetAllAsync();

            _logger.LogInformation(Constants.FinalizingEndpointLog, "ListAllAsync", "Users");

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "GetById", "User");

            var response = await _UserService.GetByIdAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "GetById", "User");

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UserViewModel User)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "CreateAsync", "User");

            await _UserService.CreateAsync(User);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "CreateAsync", "User");

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _logger.LogInformation(Constants.InitiatingEndpointLog, "DeleteAsync", "User");

            await _UserService.DeleteAsync(id);

            _logger.LogInformation(Constants.FinalizingEndpointLog, "DeleteAsync", "User");

            return NoContent();
        }
    }
}
