using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.DataAccess.Data.Repository.IRepository;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.DataAccess.Data.Repository
{
    public class FoodTypeRepository : Repository<FoodType>, IFoodTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public FoodTypeRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetFoodTypeListForDropDown()
        {
            return _db.FoodType.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public void Update(FoodType objectToBeUpdate)
        {
            var categoryFromDb = _db.FoodType.FirstOrDefault(s => s.Id == objectToBeUpdate.Id);
            categoryFromDb.Name = objectToBeUpdate.Name;
            _db.SaveChanges();
        }
    }
}
