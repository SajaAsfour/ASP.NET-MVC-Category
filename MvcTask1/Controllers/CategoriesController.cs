using Microsoft.AspNetCore.Mvc;
using MvcTask1.Data;
using MvcTask1.Models;

namespace MvcTask1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var categories = context.Categories;
            return View("Index", categories);
        }

        public ViewResult Details(int id) 
        {
            var category = context.Categories.Find(id);
            return View("Details" ,category);
        }

        public ViewResult Create()
        {
            return View("Create");
        }
        public ViewResult Store(Category request)
        {
            context.Categories.Add(request);
            context.SaveChanges();
            var categories = context.Categories;
            return View("Index" ,categories);
        }

        public ViewResult Delete(int id) 
        {
            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            var categories = context.Categories;
            return View("Index" ,categories);
        }
    }
}
