using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Recipes.Core.Dtos;
using Recipes.Database;
using Recipes.Services.Interfaces;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Services
{
    public class LoginService : ILoginService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;

        public LoginService(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        private string GenerateJSONWebToken(string userName, int id)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim("userId", id.ToString())
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(60),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<ServiceResponse<string>> LoginUser(string username, string password)
        {
            var response = new ServiceResponse<string>();

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                return null;
            }
            var tokenString = GenerateJSONWebToken(user.Username, user.Id);
            response.Data = tokenString;

            return response;
        }
    }
}
