using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class NewController : Controller
{
    // GET
    public IActionResult More()
    {
        return View();
    }
}