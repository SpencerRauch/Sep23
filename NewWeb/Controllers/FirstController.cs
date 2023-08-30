using Microsoft.AspNetCore.Mvc;

namespace NewWeb.Controllers;

public class FirstController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "<h1>Hello from the controller!</h1>";
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

    [HttpGet("view")]
    public ViewResult FirstView()
    {
        ViewBag.Name = "Bob";
        ViewBag.Number = 8;
        return View();
    }

    [HttpGet("{**path}")]
    public string Lost()
    {
        return "I think you may be lost";
    }

}