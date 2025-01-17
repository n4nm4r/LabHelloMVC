using Microsoft.AspNetCore.Mvc;

namespace LabHelloMVC.Models
{
    public class Person : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
