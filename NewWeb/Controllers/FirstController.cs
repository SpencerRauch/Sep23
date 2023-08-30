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

    [HttpGet("{**path}")]
    public string Lost()
    {
        return "I think you may be lost";
    }

}