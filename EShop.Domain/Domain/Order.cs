﻿using EShop.Domain.Identity;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Domain
{
    public class Order : BaseEntity
    {
        public string? OwnerId { get; set; }
        public EShopApplicationUser? Owner { get; set; }

        public IEnumerable<FoodItemInOrder> FoodItemsInOrder { get; set; }
    }
}
