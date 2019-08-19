using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Saioncorp.Models
{
    public class Products
    {
        [Key]
        public int          ProductId   { get; set; }
        public String       ProductName { get; set; }
        public Decimal      ProductRate { get; set; }
        public String       ProductDesc { get; set; }
    }
}
