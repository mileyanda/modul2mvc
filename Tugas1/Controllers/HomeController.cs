﻿using System.Web.Mvc;
namespace Tugas1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Welcome()
        {
            return View();
        }
    }
}