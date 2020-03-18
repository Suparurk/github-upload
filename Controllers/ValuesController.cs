using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorldWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<AppMessage> Get()
        {
            List<AppMessage> messages = new List<AppMessage>();
            messages.Add(new AppMessage() { Message = "Hello World!" });
            messages.Add(new AppMessage() { Message = "Hello Galaxy!!" });
            messages.Add(new AppMessage() { Message = "Hello Universe!!!" });
            return messages;
        }
    }
}
