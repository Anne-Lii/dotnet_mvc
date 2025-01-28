using Microsoft.AspNetCore.Mvc;

namespace mvc_m1.Controllers;

public class HomeController : Controller {

    [HttpGet("/")] //Hanterar rotadressen
    public IActionResult Default()
    {
        return RedirectToAction("Index"); // Omdirigera till /home
    }

    [HttpGet("/home")] //Justerar routing
    public IActionResult Index() 
    {
        return View();
    }

    [HttpGet("/todo")] //Justerar routing
    public IActionResult ToDoList() 
    {
        return View();
    }

    [HttpGet("/about")] //Justerar routing
    public IActionResult About() 
    {
        return View();
    }
}