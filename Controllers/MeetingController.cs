using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

        [HttpGet]

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Apply(UserInfo model)
        {
            // database
            // list
            if (ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }


            //Console.WriteLine(Name);
            //Console.WriteLine(Email);
            //Console.WriteLine(WillAttend);
        }

        [HttpGet]

        public IActionResult List()
        {

            return View(Repository.Users);
        }

        //meeting/details/2
        //basvuru-detay-1

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

    }
}