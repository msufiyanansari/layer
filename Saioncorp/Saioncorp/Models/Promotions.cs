using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Saioncorp.Models
{
    public class Promotions
    {
        [Key]
        public int          PromotionId   { get; set; }
        public String       PromotionName { get; set; }
        public Decimal      PromotionRate { get; set; }
        public String       PromotionDesc { get; set; }
    }
}
