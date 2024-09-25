using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public class Restaurant : BaseEntity
    {
        public string? RestaurantName { get; set; }
        public string? RestaurantDescription { get; set; }
        public string? RestaurantImage { get; set; }

        public string? RestaurantLocation { get; set; }

        public virtual ICollection<FoodItem>? FoodItems { get; set; }


    }
}
