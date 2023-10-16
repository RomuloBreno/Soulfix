using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soulfix.Models.Domain
{
    public class Category
    {
        private Guid IdCategory { get; set; }
        private string Name { get; set; }
        private string Color { get; set; }
        private Guid IdOwner { get; set; }
    }
}
