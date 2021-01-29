using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeedAPI.Interfaces;

namespace SeedAPI.Web.API.Controllers
{
    public class UserController : Controller
    {
        IUserMap userMap;
       public UserController(IUserMap map)
        {
            userMap = map;
        }
        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            return userMap.GetAll();
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public void Post([FromBody]string user)
        {

        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string user)
        {

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
