using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi
{
    [ApiController]
    [Route("auth")]
    public class ContactsController : ControllerBase
    {
        [EnableCors("cors")]
        [HttpPost]
        [Route("login")]
        public String AuthUserPass([FromBody] Usuario usuario) 
        {
            if(usuario.senha == "admin" && usuario.login == "admin")
            {
                return "sucess";
            }
            else
            {
                return "error";
            }
            
        }

        [HttpGet]
        [Route("teste")]
        public string teste()
        {
            return "ok";
        }
    }
}
