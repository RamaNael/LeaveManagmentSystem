using LeaveManagmentSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagmentSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new testViewModel
            {
                Name = "Rama",
                DOB = new DateTime(2003,28,06)
            };
            
            return View(data);
        }
    }
}
