using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Clase4MVC.Models;
using Clase4MVC.Services;

namespace Clase4MVC.Controllers;

public class MovieController : Controller
{

    public MovieController()
    {
       
    }

    public IActionResult Index()
    {
        var model = new List <Movie>();
        model = MovieService.GetAll();
        
        return View(model);
    }

   public IActionResult Detail(string id) 
   {
    var model = MovieService.Get(id);
    return View(model);
   }
    public IActionResult Create()
    {
        
        
        return View();
    }
    [HttpPost]
    public IActionResult Create(Movie movie)
    {
        if(!ModelState.IsValid)
        {
            return RedirectToAction("Create");
        }
        MovieService.Add(movie);
        return RedirectToAction("index");
    }

    
    public IActionResult Delete(string code)
        {
                MovieService.Delete(code);    
                return RedirectToAction("Index");       
        }
}
