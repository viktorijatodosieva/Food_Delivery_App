using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.DTO
{
    public class AddToCartDto
    {
        public Guid foodId {  get; set; }
        public string? foodName { get; set; }
        public int quantity { get; set; }
    }
}
