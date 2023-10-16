using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soulfix.Models.Domain;

namespace Soulfix.Models
{
    public class UserModel
    {
        public int Id { get; protected set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? CPF { get; set; }
        public string? Job { get; set; }


   
    }

   


}
