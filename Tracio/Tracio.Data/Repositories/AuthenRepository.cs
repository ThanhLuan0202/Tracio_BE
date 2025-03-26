using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Data;
using Tracio.Data.Entities;
using Tracio.Data.Interfaces;
using Tracio.Data.Models.LoginModel;

namespace Tracio.Data.Repositories
{
    public class AuthenRepository : Repository<User>, IAuthenRepository
    {
        private readonly TracioDbContext _DbContext;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AuthenRepository(TracioDbContext DbContext, IConfiguration configuration) : base(DbContext) 
        {
            _DbContext = DbContext;
            _configuration = configuration;
        }

        

        public async Task<string> Login(LoginModel model)
        {
            var user = await Entities
                .Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Status == "Active" && x.Email.ToLower().Equals(model.Email));

            if (user == null)
            {
                throw new Exception($"User not existed !!");
            }

            if (!BCrypt.Net.BCrypt.Verify(model.Password, user.Password))
            {
                throw new Exception($"Password wrong !!");
            }

            var claims = new[]
            {
        new Claim(ClaimTypes.Name, user.FullName),
        new Claim(ClaimTypes.Role, user.Role.RoleName),
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.NameIdentifier, user.FullName.ToString()),
        //new Claim("Image", user.Image != null ? user.Image.ToString() : string.Empty)
    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public Task<bool> Logout(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Register(User newUser)
        {
            try
            {
                var existUser = await Entities
                    .FirstOrDefaultAsync(x => x.Email == newUser.Email || x.PhoneNumber == newUser.PhoneNumber);

                if (existUser != null)
                {
                    if (existUser.Email == newUser.Email)
                    {
                        throw new Exception($"Email: {newUser.Email} is exist !");
                    }

                    if (existUser.PhoneNumber == newUser.PhoneNumber)
                    {
                        throw new Exception($"Phone number: {newUser.PhoneNumber} is exist !");
                    }
                }

                string password = BCrypt.Net.BCrypt.HashPassword(newUser.Password);
                newUser.Password = password;

                await Entities.AddAsync(newUser);
                await _DbContext.SaveChangesAsync();

                return newUser;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đăng ký: {ex.Message}");
            }
        }

        
    }
}
