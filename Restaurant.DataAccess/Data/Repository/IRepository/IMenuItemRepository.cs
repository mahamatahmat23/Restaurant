using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.DataAccess.Data.Repository.IRepository
{
   public interface IMenuItemRepository : IRepository<MenuItem>
    {
        void Update(MenuItem menuItem);
       
    }
}
