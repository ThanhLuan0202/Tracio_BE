using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tracio.Data;
using Tracio.Data.Entities;
using Tracio.Data.Models.LoginModel;
using Tracio.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tracio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {

        private readonly IAuthenService _service;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AuthenController(IMapper mapper, IAuthenService service, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _service = service;
            _unitOfWork = unitOfWork;
        }
       

        

        // POST api/<AuthenController>
        [HttpPost]
        [Route("Login")]

        public async Task<ActionResult<User>> Login([FromBody] LoginModel loginModel)
        {

            if (loginModel == null || string.IsNullOrEmpty(loginModel.Email) || string.IsNullOrEmpty(loginModel.Password))
            {
                return BadRequest(new { code = 400, message = "Invalid username or password" });
            }
            try
            {
                //_unitOfWork.BeginTransaction();
                var token = await _service.Login(loginModel);
                if (string.IsNullOrEmpty((string?)token))
                {
                    return Unauthorized(new { code = 401, message = "Invalid username or password" });
                }
                var cookieOptions = new CookieOptions
                {
                    HttpOnly = false,
                    Secure = true,   
                    SameSite = SameSiteMode.None, 
                    Expires = DateTime.Now.AddDays(7),
                    Path = "/",
                    
                };
                Response.Cookies.Append("authToken", (string)token, cookieOptions);
                //_unitOfWork.CommitTransaction();

                return Ok(new { code = 200, token = token, message = "Login successful" });
            }
            catch (Exception ex)
            {
                //_unitOfWork.RollbackTransaction();
                return StatusCode(StatusCodes.Status500InternalServerError, new { code = 500, message = ex.Message });
            }

        }

        [HttpPost]
        [Route("Register")]

        public async Task<ActionResult<User>> Register([FromBody] RegisterLoginModel registerLoginModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newUser =  _mapper.Map<User>(registerLoginModel);

             await _service.Register(newUser);

            return Ok(newUser);


        }


        }
}
