using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChatRESTAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public int Id()
        {
            return 1;
        }

        [HttpGet("{id}")]
        public string Get(int Id)
        {
            return "User";
        }

        [HttpPut("{id}")]
        public void Put(int Id, [FromBody]string value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
