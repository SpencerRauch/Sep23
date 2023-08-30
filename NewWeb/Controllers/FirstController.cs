using Microsoft.AspNetCore.Mvc;

namespace NewWeb.Controllers;

public class FirstController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "<h1>Hello from the controller!</h1>"; //html does not render
    }

    [HttpGet("two")]
    public string Two()
    {
        return "Page two!";
    }

    [HttpGet("params/{id}/{name}")]
    public string Params(int id, string name)
    {
        return $"{name} is id {id}";
    }

    //can ommit view name if it matches action identifier
    //can access view folder that matches controller or shared
    [HttpGet("view")]
    public ViewResult FirstView()
    {
        ViewBag.Name = "Bob";
        ViewBag.Number = 8;
        return View();
        // return View("FirstView");
    }

    [HttpGet("form")]
    public ViewResult MyForm()
    {
        return View();
    }

    // [HttpPost("process")]
    // public RedirectResult Process(string Passcode)
    // {
    //     Console.WriteLine(Passcode);
    //     return Redirect("view");
    // }

    // [HttpPost("process")]
    // public RedirectToActionResult Process(string Passcode)
    // {
    //     Console.WriteLine(Passcode);
    //     return RedirectToAction("FirstView");
    // }

    [HttpPost("process")]
    public IActionResult Process(string Passcode)
    {
        if (Passcode == "secret")
        {
            return RedirectToAction("FirstView");
        }

        return View("TryAgain");

    }

    //catch all
    [HttpGet("{**path}")]
    public string Lost()
    {
        return "I think you may be lost";
    }

}