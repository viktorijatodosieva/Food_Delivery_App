using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    [Table("PartnerBooks")]
    public class PartnerBook
    {
        [Key]
        public string? Name { get; set; }
    }
}
