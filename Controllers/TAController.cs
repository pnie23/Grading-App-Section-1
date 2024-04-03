using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class TAController : Controller
    {
        public IActionResult Rubric()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            var names = _repo.TAs
                .OrderBy(x => x.first_name).ToList();

            ViewBag.TAs = _repo.TAs
                .ToList();

            return View(names);
        }

        private IGradingAppRepository _repo;

        public TAController(IGradingAppRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
