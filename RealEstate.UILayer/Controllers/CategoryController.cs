using RealEstate.BusinessLayer.Abstract;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.UILayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = _categoryService.TGetByID(id);
            _categoryService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = _categoryService.TGetByID(id);
            return View(values); 
            //açıklama
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            category.CategoryStatus = true;
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}