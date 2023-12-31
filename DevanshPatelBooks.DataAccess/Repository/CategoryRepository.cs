﻿using DevanshPatelBooks.DataAccess.Repository.IRepository;
using DevanshPatelBooks.Models;
using DevanshPatelBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevanshPatelBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update (Category Category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == Category.Id);
            if (objFromDb !=null)
            {
                objFromDb.Name = Category.Name;
                _db.SaveChanges();
            }
        }
    }
}
