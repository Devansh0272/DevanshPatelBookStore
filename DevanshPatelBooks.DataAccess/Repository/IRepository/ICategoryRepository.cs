using DevanshPatelBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevanshPatelBooks.DataAccess.Repository.IRepository
{
   public  interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category Category);
    }
}
