using BirtdayApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BirtdayApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InviteForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InviteForm(InviteModel model)
        {
            if(ModelState.IsValid)
            {
                Database.Add(model);
                return View("Thanks",model);

            }
            return View(model);
        }
        [System.Web.Mvc.ChildActionOnly]
        public IActionResult Katilanlar()
        {
            return PartialView(Database.Liste.Where(i=>i.State == true));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}