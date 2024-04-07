using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using rubricaWeb.Models;

namespace rubricaWeb.Controllers;

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

    public IActionResult Privacy()
    {
        List<Persona> Lista = new();
        Lista.Add (new Persona{Nome="Maurizio"});
        Lista.Add(new Persona{Nome="Marco"});
        Lista.Add(new Persona{Nome="Francesco"});

        /*
        List<Generalità> Cognomi = new();
        Cognomi.Add(new Generalità{Cognome="Conti"});
        Cognomi.Add(new Generalità{Cognome="Bucci"});
        Cognomi.Add(new Generalità{Cognome="Stoppa"});
        */
        return View( Lista );
    }

    public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
