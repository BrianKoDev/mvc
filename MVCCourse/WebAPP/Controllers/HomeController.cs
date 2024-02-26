using Microsoft.AspNetCore.Mvc;

namespace WebAPP.Controllers
{
    public class HomeController : Controller
    {
        //Action methods
        public IActionResult Index()
        {
            return View() ;
        }

     
    }
}
