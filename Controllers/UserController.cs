using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CobbleStoneWebAPI.Models;

namespace CobbleStoneWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> Users = new List<User>
        {
            new User { Id = 1, Name = "John Doe", Email = "john@example.com", Phone = "123-456-7890" },
            new User { Id = 2, Name = "Jane Doe", Email = "jane@example.com", Phone = "098-765-4321" },
            new User { Id = 3, Name = "Bony Patel", Email = "bony@example.com", Phone = "123-123-1234"},
            new User { Id = 4, Name = "First Last", Email = "First@example.com", Phone = "111-111-1111"}
        };

        // GET: api/users
        [HttpGet]
        public async Task<List<User>> GetUsers()
        {
            return await Task.Run(() => Users.ToList());
        }

    }
}
