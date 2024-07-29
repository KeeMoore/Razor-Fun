using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun.Controllers;

public class Razor_FunController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }
}
