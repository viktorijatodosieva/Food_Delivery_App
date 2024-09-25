using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public class FoodItem : BaseEntity
    {
        public string? FoodName { get; set; }
        public string? FoodDescription { get; set; }
        public string? FoodImage { get; set; }
        [Required]
        public int Price { get; set; }
        public Guid? RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}
