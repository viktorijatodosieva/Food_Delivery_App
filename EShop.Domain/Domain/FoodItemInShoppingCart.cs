using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public  class FoodItemInShoppingCart : BaseEntity
    {
        public Guid FoodItemId { get; set; }
        public Guid ShoppingCartId { get; set; }
        public FoodItem? FoodItem { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }
        public int Quantity { get; set; }
    }
}
