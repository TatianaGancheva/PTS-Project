using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace PTS_Project.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Student/Index.cshtml");
        }
    }
}