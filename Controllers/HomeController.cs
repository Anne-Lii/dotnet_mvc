using Microsoft.AspNetCore.Mvc;

namespace mvc_m1.Controllers;

public class HomeController : Controller {

    public IActionResult Index() {
        return View();
    }

    public IActionResult ToDoList() {
        return View();
    }

    public IActionResult About() {
        return View();
    }
}