using Microsoft.AspNetCore.Mvc;

namespace StudentMS.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }


        public IActionResult Edit()
        {
            return View();
        }
    }
}
