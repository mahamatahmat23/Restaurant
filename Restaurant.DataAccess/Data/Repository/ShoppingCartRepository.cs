﻿using Restaurant.DataAccess.Data.Repository.IRepository;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.DataAccess.Data.Repository
{
   public class ShoppingCartRepository : Repository<ShoppingCart> , IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public int DecrementCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Count -= count;
            return shoppingCart.Count;
        }

        public int IncrementCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Count += count;
            return shoppingCart.Count;
        }
    }
}
