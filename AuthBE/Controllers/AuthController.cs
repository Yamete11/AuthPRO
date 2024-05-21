using AuthBE.DTOs;
using AuthBE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuthBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;

        public AuthController(IAuthService service)
        {
            this._service = service;
        }

        [HttpGet]
        public async Task<List<UserDTO>> GetUsers()
        {
            return await _service.GetUsers();
        }
    }
}
