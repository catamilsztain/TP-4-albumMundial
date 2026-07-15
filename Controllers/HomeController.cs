using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_AlbumMundial.Models;

namespace TP04_AlbumMundial.Controllers;

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
    [HttpPost]

    public IActionResult Album(){
        int[] figuritasSobre = new int[6];
        Jugadores[] jugadores = new Jugadores[6];
        Figurita figurita1 = new Figurita();
        for (int i = 0; i<figuritasSobre.Length; i++){
            figuritasSobre[i] = figurita1.ObtenerFigu();
            BD.SumarRepetida(figuritasSobre[i]);
        }
        jugadores = BD.ObtenerJugador(figuritasSobre);
        ViewBag.Jugadores = jugadores;

        return View("obteni2");
    }

    public IActionResult Archivo(){

        ViewBag.Album = BD.ObtenerAlbum();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
