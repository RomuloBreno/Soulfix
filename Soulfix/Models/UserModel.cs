using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soulfix.Models.Domain;

namespace Soulfix.Models
{
    public class UserModel
    {
        public int Id { get;  set; }
        [Required(ErrorMessage ="Digite o Nome Completo")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Digite o Email")]
        [EmailAddress(ErrorMessage = "Digite um email valido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Digite o Telefone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Digite o CPF")]
        public string? CPF { get; set; }
        [Required(ErrorMessage = "Escolha o Job")]
        public string? Job { get; set; }


   
    }

   


}
