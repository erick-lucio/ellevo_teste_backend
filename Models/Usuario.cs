using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webapi
{
    public class Usuario
    {
        public string login { get; set; }
        public string senha { get; set; }
    }
}