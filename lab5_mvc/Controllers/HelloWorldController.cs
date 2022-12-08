using Microsoft.AspNetCore.Mvc;

namespace lab5_mvc.Controllers;
public class HelloWorldController:Controller{
    public IActionResult Index() {
        return View();
    }
    public string Welcome() {
        return "會接在後面的Welcome";
    }
}