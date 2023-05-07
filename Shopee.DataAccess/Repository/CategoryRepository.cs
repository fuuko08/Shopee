using System;
using System.Linq.Expressions;
using Shopee.DataAccess.Data;
using Shopee.DataAccess.Repository.IRepository;
using Shopee.Models;

namespace Shopee.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository 
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}

