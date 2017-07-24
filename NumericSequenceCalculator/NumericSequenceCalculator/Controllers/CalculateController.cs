using NumericSequenceCalculator.Models;
using NumericSequenceCalculator.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumericSequenceCalculator.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
     
        public ActionResult GetSequence()
        {

             return View("GetSequence");
        }
                
        public ActionResult _SequenceNumbers(int Number,string SequenceName)
        {
            var model = new List<SequenceResult>();
            if (this.ModelState.IsValid)
            {
                switch (SequenceName)
                {
                    case "All":
                        model = Enumerable.Range(1, Number).ToList().ConvertAll<string>(x => x.ToString()).Select(x => new SequenceResult { Number = x }).ToList();
                        break;
                    case "Even":
                        model = new SequenceResult().GetEvenNumbers(Number).Select(x => new SequenceResult { Number = x }).ToList();
                        break;
                    case "Odd":
                        model = new SequenceResult().GetOddNumbers(Number).Select(x => new SequenceResult { Number = x }).ToList();
                        break;
                    case "Fibonacci":
                        model = new SequenceResult().GetFibonacciNumbers(Number).Select(x => new SequenceResult { Number = x }).ToList();
                        break;
                    case "Multiples":
                        model = new SequenceResult().GetMultiples(Number).Select(x => new SequenceResult { Number = x }).ToList();
                        break;
                    default:
                        break;
                }

                return PartialView("_SequenceNumbers", model);
            }
            else return View();
        }
    }
}