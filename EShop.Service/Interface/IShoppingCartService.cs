﻿using EShop.Domain.Domain;
using EShop.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDto getShoppingCartInfo(string userId);
        bool deleteFoodFromShoppingCart(string userId, Guid productId);
        bool order(string userId);
        bool AddToShoppingConfirmed(FoodItemInShoppingCart model, string userId);
        public AddToCartDto getProductInfo(Guid Id);
        public bool AddToShoppingConfirmed(string userId, AddToCartDto model);
    }
}
