using CalculatorTwo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorTwo.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            Calculator model = new Calculator(); 
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Calculator model)
        {
            return RedirectToAction("Result", model);
        }

        public IActionResult Result(Calculator model)
        {
            double result = 0;
            if (model.Operation == Operation.plus)
            {
                result = model.Num1 + model.Num2;
            }
            else if (model.Operation == Operation.minus)
            {
                result = model.Num1 - model.Num2;
            }
            else if (model.Operation == Operation.multiply)
            {
                result = model.Num1 * model.Num2;
            }
            else
            {
                result = model.Num1 / model.Num2;
            }

            model.Result = result;
            return View(model);
        }
    }
}
