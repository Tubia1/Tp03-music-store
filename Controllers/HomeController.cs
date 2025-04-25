using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_MUSICSTORE.Models;

namespace TP03_MUSICSTORE.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
