using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MPOnew.Areas.Identity.Data;
using MPOnew.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MPOnew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase
    {
        private MPODbContext _dbContext;
        private readonly UserManager<MPOnewUser> _userManager;
        private readonly SignInManager<MPOnewUser> _signInManager;

        public ValuesController(MPODbContext dbContext,
            UserManager<MPOnewUser> userManager,
            SignInManager<MPOnewUser> signInManager
            )
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;

        }


        [HttpGet("getSome")]
        [AllowAnonymous]
        public ActionResult GetSome()
        {
            List<string> myList = new List<string>() { "car", "same shit" };
            return Ok(myList);
        }

        [HttpGet("getSomeAuth")]
        public ActionResult GetSomeAuth()
        {
            List<string> myList = new List<string>() { "car", "same shit", "same shit again" };
            return Ok(myList);
        }

        [AllowAnonymous]
        [HttpPost("getToken")]

        public async Task<ActionResult> GetToken([FromBody] LoginModel loginModel)
        {

            var user = _dbContext.Users.FirstOrDefault(x => x.Email == loginModel.Email);

            if (user != null)
            {
                var signInResult = await _signInManager.CheckPasswordSignInAsync(user, loginModel.Password, false);
                if (signInResult.Succeeded)
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes("sceret_key_12_254_212_2122_222");
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                        new Claim(ClaimTypes.Name, loginModel.Email)
                        }),
                        Expires = DateTime.UtcNow.AddDays(2),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var tokenString = tokenHandler.WriteToken(token);

                    return Ok(new { Token = tokenString });
                }
                else
                {
                    return Ok("Failed, try again");
                }
            }
            return Ok("Failed, try again");
        }


        [AllowAnonymous]
        [HttpPost("register")]

        public async Task<ActionResult> Register([FromBody] LoginModel loginModel)
        {
            MPOnewUser mPOnewUser = new MPOnewUser()
            {
                Email = loginModel.Email,
                UserName = loginModel.Email,
                EmailConfirmed = false

            };



            var result = await _userManager.CreateAsync(mPOnewUser, loginModel.Password);

            if(result.Succeeded)
            {

                return Ok(new { Result = "Register Success" });
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach(var error in result.Errors)
                {
                    stringBuilder.Append(error.Description);
                    stringBuilder.Append("\r\n");

                }
                return Ok(new { Result = $"Register Fail:{stringBuilder.ToString()}" });

            }
        }
    }
}