using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soulfix.Models.Domain;

namespace Soulfix.Models
{
    public class Category
    {
        public int Id { get; protected set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public int? IdOwner { get; set; }




    }




}
