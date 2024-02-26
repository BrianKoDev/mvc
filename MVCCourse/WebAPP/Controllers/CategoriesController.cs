using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using WebAPP.Models;

namespace WebAPP.Controllers
{
    public class CategoriesController : Controller
    {
        //Action Methods
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit(int? id)
        {
            //combine view and model together

            var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };

            //Provide instance of model class
            return View(category);

           
        }
    }
}
