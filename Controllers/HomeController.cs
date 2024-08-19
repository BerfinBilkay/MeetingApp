
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.AddControllers
{
    public class HomeController : Controller
    {

        //localhost/home
        //localhost
        public IActionResult Index()
        {



            int clock = DateTime.Now.Hour;

            //ViewBag.hi = clock > 12 ? "Have a nice day" : "Good Morning";
            //ViewBag.UserName = "Berfin";

            ViewData["hi"] = clock > 12 ? "Have a nice day" : "Good Morning";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

            //ViewData["UserName"] = "Berfin";

            var meetinginfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };

            return View(meetinginfo);
        }
    }
}