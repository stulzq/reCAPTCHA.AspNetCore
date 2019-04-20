﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using reCAPTCHA.AspNetCore.Example.Models;

namespace reCAPTCHA.AspNetCore.Example.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecaptchaService _recaptcha;

        public HomeController(IRecaptchaService recaptcha)
        {
            _recaptcha = recaptcha;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View(new ContactModel());
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactModel model)
        {
            ViewData["Message"] = "Your contact page.";

            var recaptcha = await _recaptcha.Validate(Request);
            if (!recaptcha.Success)
                ModelState.AddModelError("Recaptcha", "There was an error validating recatpcha. Please try again!");

            return View(!ModelState.IsValid ? model : new ContactModel());
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
