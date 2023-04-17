using Microsoft.AspNetCore.Mvc;
using S3_MVCPractice.Models;

namespace S3_MVCPractice.Controllers
{
    public class WelcomeController : Controller
    {
        private static List<AthleteViewModel> athlete = new List<AthleteViewModel>();
        public IActionResult Index()
        {
            return View(athlete);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult AddAthlete(AthleteViewModel alt)
        {
            athlete.Add(alt);
            return RedirectToAction("Index");
        }
    }
}
