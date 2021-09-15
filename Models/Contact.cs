using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webapi
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}