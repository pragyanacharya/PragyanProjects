using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumericSequenceCalculator.Controllers
{
    public class InstructionsController : Controller
    {
        public ActionResult ReadMe()
        {
            return View("ReadMe");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Details";

            return View("Contact");
        }
    }
}