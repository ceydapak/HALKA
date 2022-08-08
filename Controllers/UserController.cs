using _HALKA.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace _HALKA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest request)
        {
            if(_context.Users.Any(u=> u.Mail == request.Mail))
            {
                return BadRequest("User already exist");
            }
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
            var user = new User
            {
                UserName = request.UserName,    
                UserLastname = request.UserLastname,
                Birthdate= request.Birthdate,
                IsStudent = request.IsStudent,  
                School= request.School,
                Class= request.Class,
                Institution= request.Institution,
                Phone= request.Phone,   
                LibraryName= request.LibraryName,
                Mail = request.Mail,
                Password = request.Password,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                VerToken = CreateRandomToken()
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);    
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Mail == request.Mail);
            if(user == null)
            {
                return BadRequest("User does not exist");
            }
            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Password is wrong");
            }
            //if (user.VAt == null)
            //{
            //    return BadRequest("Not verified");
            //}
           
            return Ok(user);
        }

        [HttpPost("verify")]
        public async Task<IActionResult> Verify(string token)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.VerToken == token);
            if (user == null)
            {
                return BadRequest("Invalid Token");
            }
            user.VAt = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok("User verified");
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Mail == email);
            if (user == null)
            {
                return BadRequest("User not found.");
            }
            user.PResetToken = CreateRandomToken();
            user.ResetTokenE = DateTime.Now.AddDays(1);
            await _context.SaveChangesAsync();
            return Ok("You may reset your password now!");

        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPassRequest r)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.PResetToken == r.Token);
            if (user == null || user.ResetTokenE < DateTime.Now)
            {
                return BadRequest("Invalid Token");
            }
            CreatePasswordHash(r.Password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.PResetToken = null;
            user.ResetTokenE = null;
            await _context.SaveChangesAsync();
            return Ok("Password reset!");

        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using( var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }



        private bool VerifyPasswordHash(string password,  byte[] passwordHash,  byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);

            }
        }




        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }
    }
}
