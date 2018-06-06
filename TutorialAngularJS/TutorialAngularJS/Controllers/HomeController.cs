using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorialAngularJS.Models;

namespace TutorialAngularJS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControlScope()
        {
            return View();
        }

        public IActionResult FiltroRepeticion()
        {
            return View();
        }

        public IActionResult HttpRequestView()
        {
            return View();
        }
    }
}
