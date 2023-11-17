using DevanshPatelBooks.DataAccess.Repository.IRepository;
using DevanshPatelBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevanshPatelBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _UnitOfWork;
        public CategoryController(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)          //action method for Upsert
        {
            Category category = new Category();       //using DevanshPatelBookS.Models;
            if (id == null)
            {
                // this is for create
                return View(category);
            }
            //this for the edit
            category = _UnitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        // API calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _UnitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}