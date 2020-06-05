using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DateValidator.Models;

namespace DateValidator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult HandleSubmission(Trip trip)
        {

            if (ModelState.IsValid)
            { 
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }


        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
