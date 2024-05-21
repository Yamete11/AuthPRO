using AuthBE.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuthBE.Services
{
    public interface IAuthService
    {
        public Task<List<UserDTO>> GetUsers();
    }
}
