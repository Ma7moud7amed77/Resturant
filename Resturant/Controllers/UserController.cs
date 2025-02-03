using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resturant.DTO;
using Resturant.Models;

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public UserController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users= _dbContext.Users;
            return Ok(users);
        }
    [HttpPost]
    public async Task<IActionResult>AddUser(dtoUser dto)
    {
        
        var user = new User
        {

            Name = dto.Name,
            Email = dto.Email,
            Password= dto.Password,
            Role = dto.Role,
            

        };
            
           await _dbContext.Users.AddAsync(user);
           await _dbContext.SaveChangesAsync();
            return Ok(user);
        
    }

        [HttpGet("ById")]
        public async Task<IActionResult>GetById(int id)
        {
            var user= _dbContext.Users.FindAsync(id);
            return Ok(user);
        } 
        [HttpGet("ByRoll")]
        public async Task<IActionResult>GetByRoll(string role)
        {
            var user= _dbContext.Users.FirstOrDefault(x => x.Role == role);
            return Ok(user);
        }
        [HttpPut]
        public async Task<IActionResult>UpdateUser(int id, dtoUser dto)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if(user == null)
            {
                return NotFound("No user with this id ");
            }
            else
            {
                
                user.Name = dto.Name;
                user.Email = dto.Email;
                user.Password = dto.Password;
                user.Role = dto.Role;
               await _dbContext.SaveChangesAsync();
                return Ok(user);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);

            return user == null
                ? NotFound("No user with this ID")
                : await DeleteAndReturnUser(user);
        }

        private async Task<IActionResult> DeleteAndReturnUser(User user)
        {
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
            return Ok("Deleted successfully");
        }

    }
}
