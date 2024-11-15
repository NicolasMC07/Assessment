using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Config;
using APiClinique.Data;
using APiClinique.Dtos;
using APiClinique.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace APiClinique.Controllers.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly Utilities _utilities;

        public AuthenticationController(AppDbContext context, Utilities utilities)
        {
            _context = context;
            _utilities = utilities;
        }

        [HttpPost("register")]
        [SwaggerOperation(Summary = "Register a new user", Description = "Registers a new user in the system, either as Admin, Doctor, or Patient.")]
        public async Task<IActionResult> Register(UserDTO userDTO)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_context.Users.Any(u => u.Email == userDTO.Email))
            {
                return BadRequest("Email already exists");
            }
      
            var user = new User
            {
                Name = userDTO.Name,
                Email = userDTO.Email,
                Password = _utilities.EncryptSHA256(userDTO.Password), 
                Role = userDTO.Role,  
                CreatedAt = DateTime.UtcNow 
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok("User registered successfully");
        }


        [HttpPost("login")]
        [SwaggerOperation(Summary = "Login", Description = "Authenticates a user and returns a JWT token.")]
        public async Task<IActionResult> Login(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var User = await _context.Users.FirstOrDefaultAsync(u => u.Email == userDTO.Email);
            if (User == null)
            {
                return Unauthorized("Invalid email");
            }

            var passwordIsValid = User.Password == _utilities.EncryptSHA256(userDTO.Password);

            if (!passwordIsValid)
            {
                return Unauthorized("Invalid password");
            }

            var token = _utilities.GenerateJwtToken(User);
            return Ok(new
            {
                message = "Please store this token:",
                jwt = token
            });
        }

    }
}