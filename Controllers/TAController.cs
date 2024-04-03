﻿using Grading_App_Section_1.Models;
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
            return View();
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
