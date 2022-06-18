using ECommerceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ECommerceDBContext ec;
        public UserController(ECommerceDBContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return ec.Users;
        }
        [HttpPost]
        public string Post([FromBody] User user)
        {
            ec.Users.Add(user);
            ec.SaveChanges();
            return "success";
        }
    }
}
