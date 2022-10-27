using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BuberDinner.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> _logger;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(
            ILogger<AuthenticationController> logger,
            IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            _logger = logger;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(
                request.FirstName, 
                request.LastName, 
                request.Email, 
                request.Password
            );

            var response = new AuthenticationResponse(
                authResult.Id, 
                authResult.FirstName, 
                authResult.LastName, 
                authResult.Email, 
                authResult.Token
            );
            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(
                request.Email, 
                request.Password
            );

            var response = new AuthenticationResponse(
                authResult.Id, 
                authResult.FirstName, 
                authResult.LastName, 
                authResult.Email, 
                authResult.Token
            );
            return Ok(response);
        }
    }
}