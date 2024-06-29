using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCalculatorApp.web.Models;

namespace MyCalculatorApp.web.Controllers;

public class HomeController : Controller
{
    

    [HttpGet]
    public IActionResult Index()
    {        
        return View(new CalculatorModel());
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult Index(CalculatorModel model, string operation)
    {
        switch (operation)
            {
                case "add":
                    model.Result = model.Value1 + model.Value2;
                    break;
                case "sub":
                    model.Result = model.Value1 - model.Value2;
                    break;
                case "mul":
                    model.Result = model.Value1 * model.Value2;
                    break;
                case "div":
                    if (model.Value2 != 0)
                    {
                        model.Result = (double)model.Value1 / model.Value2;
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Cannot divide by zero");
                    }
                    break;
                default:
                    ModelState.AddModelError(string.Empty, "Invalid operation");
                    break;
            }
        return View(model);
        

    }
}
