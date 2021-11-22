using FirstAPI.Interfaces;
using FirstAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors()]
    public class UserController : ControllerBase
    {
        private readonly IUser _userService;

       
        public UserController(IUser userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var myUser = _userService.Login(user);
            if (myUser == null)
                return BadRequest("Invalid Username or password");
            else
                return Ok(myUser);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetUsers());
        }
    }
}
