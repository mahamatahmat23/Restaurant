﻿using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.DataAccess.Data.Repository.IRepository
{
  public  interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        int IncrementCount(ShoppingCart shoppingCart, int count);
        int DecrementCount(ShoppingCart shoppingCart, int count);

    }
}
