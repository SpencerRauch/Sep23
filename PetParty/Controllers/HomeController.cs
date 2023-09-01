using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetParty.Models;

namespace PetParty.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public static List<Pet> AllPetsList = new();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        ViewBag.AllPets = new List<SelectListItem> {
            new SelectListItem("Dog", "Dog"),
            new SelectListItem("Cat", "Cat"),
            new SelectListItem("Turtle", "Turtle"),
            new SelectListItem("Panda", "Panda"),
            new SelectListItem("Monkey", "Monkey"),
        };
        return View("Index");
    }

    [HttpPost("pets/create")]
    public IActionResult CreatePet(Pet p)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine($"{p.Name} is a {p.Age} year old {p.Species}");
            AllPetsList.Add(p);
            return RedirectToAction("AllPets"); 

        }

        return Index();
        
    }

    [HttpGet("pets")]
    public ViewResult AllPets()
    {
        return View("AllPets",AllPetsList);
    }

    // ***************************************************************  

    [HttpPost("pets/create2")]
    public IActionResult CreatePet2(Pet p)
    {
        if (ModelState.IsValid)
        {
            HttpContext.Session.SetString("Name", p.Name);
            HttpContext.Session.SetString("Species", p.Species);
            HttpContext.Session.SetInt32("Age", p.Age);

            return RedirectToAction("AllPets2"); 
        }

        ViewBag.AllPets = new List<SelectListItem> {
            new SelectListItem("Dog", "Dog"),
            new SelectListItem("Cat", "Cat"),
            new SelectListItem("Turtle", "Turtle"),
            new SelectListItem("Panda", "Panda"),
        };
        return View("Index");
        
    }

    [HttpGet("pets2")]
    public ViewResult AllPets2()
    {
        string? Name = HttpContext.Session.GetString("Name");
        string? Species = HttpContext.Session.GetString("Species");
        int? Age = HttpContext.Session.GetInt32("Age");

        // if (Name == "Tex")
        // {
        //     return View("Index");
        // }

        Console.WriteLine($"{Name} is a {Age} year old {Species}");
        return View("YourPet");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
