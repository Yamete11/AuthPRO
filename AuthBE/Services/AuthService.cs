using AuthBE.Context;
using AuthBE.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthBE.Services
{
    public class AuthService : IAuthService
    {
        private readonly MyDbContext _context;

        public AuthService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserDTO>> GetUsers()
        {
            return await _context.Users
                .Select(x => new UserDTO
                {
                    Name = x.Name,
                    Surname = x.Surname,
                    Login = x.Login,
                    Password = x.Password,
                    Email = x.Email
                }).ToListAsync();
        }
    }
}
