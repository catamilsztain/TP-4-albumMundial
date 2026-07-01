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
        Figurita figurita1 = new figurita();
        public int[] figuritasSobre = {get;set;}
        public bool[] pegada = {get;set;}

        for (int i = 0; i<7; i++){
            figuritasSobre[i] = figurita1.ObtenerFigu();
            if(figurita1.esPegada() == false){
                
            }
        }
        

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
