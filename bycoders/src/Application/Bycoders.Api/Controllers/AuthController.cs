using Bycoders.Domain.Core.Services.Auth;
using Bycoders.Domain.Infrastructure.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bycoders.Api.Controllers
{
    /// <summary>
    /// Controller for authentication user
    /// </summary>
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        /// <summary>
        /// User Login
        /// </summary>
        /// <param name="login">Object with email e password</param>
        /// <returns>User Token</returns>
        [Route("login")]
        [HttpPost]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(typeof(string), 500)]
        public IActionResult Login([FromBody] Login login)
        {
            try
            {
                return Ok( _authService.Login(login));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
