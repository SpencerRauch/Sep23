using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
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
        return View();
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
        return View("Index");
        
    }

    [HttpGet("pets")]
    public ViewResult AllPets()
    {
        return View("AllPets",AllPetsList);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
