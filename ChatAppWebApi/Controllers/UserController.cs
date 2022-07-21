using ChatAppWebApi.DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet("User")]
        public IActionResult GetList()
        {
            UserDbContext userDbContext = new UserDbContext();
            var userList = userDbContext.Users.ToList();
            if (userList.Count == 0)
            {
                return NotFound();
            }
            return Ok(userList);
        }

        [HttpPost("Add")]
        public IActionResult Add(User user)
        {
            UserDbContext userDbContext = new UserDbContext();
             userDbContext.Add(user);
            userDbContext.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetListById(int id)
        {
            UserDbContext userDbContext = new UserDbContext();
            var user = userDbContext.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(user);
            }
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            UserDbContext userDbContext = new UserDbContext();
            var user = userDbContext.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                userDbContext.Remove(user);
                userDbContext.SaveChanges();
                return Ok();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(User user)
        {
            UserDbContext userDbContext = new UserDbContext();
            var users = userDbContext.Users.Find(user.Id);
            if (users == null)
            {
                return NotFound();
            }
            else
            {
                users.Name = user.Name;
                users.Mail = user.Mail;
                users.Gender = user.Gender;

                userDbContext.Update(users);
                userDbContext.SaveChanges();
                return Ok();

            }
        }

    }
}
