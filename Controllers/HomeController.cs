using Microsoft.AspNetCore.Mvc;
using mvc_m1.Models;

namespace mvc_m1.Controllers;

public class HomeController : Controller {

    [HttpGet("/")] //Hanterar grundrouting
    public IActionResult Default()
    {
        return RedirectToAction("Index"); //Omdirigerar till /home
    }


    [HttpGet("/home")] //Justerar routing
    public IActionResult Index() 
    {
        ViewData["Message"] = "Välkommen till min MVC-applikation från Controllern med ViewData som skickar meddelande med en nyckel-värde-par struktur!"; //Skickar ViewData till vyn
        ViewBag.Message = "Detta meddelande är också skickat från Controllern, fast med ViewBag =)";
        return View();
    }


   [HttpGet("/todo")]
    public IActionResult ToDoList()
    {
        var todoItems = new List<ToDoItem>
        {
            new ToDoItem { Id = 1, Task = "Handla mat" },
            new ToDoItem { Id = 2, Task = "Plugga C#" },
            new ToDoItem { Id = 3, Task = "Gå till gymmet" }
        };

        return View(todoItems); //Skickar listan som modell
    }

    [HttpGet("/about")] //Justerar routing
    public IActionResult About() 
    {
        
        string username = HttpContext.Session.GetString("Username") ?? "Gäst"; //Hämtar namn från session eller sätt "Gäst" om ingen data finns
        return View("About", username);// Omdirigera till "About"-sidan
    }

    [HttpPost("/setname")]
    public IActionResult SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return BadRequest("Fyll i namn.");
        } else {
            //Sparar namnet i sessionen
            HttpContext.Session.SetString("Username", name);
            return RedirectToAction("About");//Omdirigerar till About-sidan
        }
        
    }
}