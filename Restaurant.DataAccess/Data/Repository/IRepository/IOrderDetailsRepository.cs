﻿using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.DataAccess.Data.Repository.IRepository
{
   public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails orderDetails);
    }
}
