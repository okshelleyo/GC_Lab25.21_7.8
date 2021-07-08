using GC_Lab21._25_7._8._21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Lab21._25_7._8._21.Controllers
{
   
    public class HomeController : Controller
    {
        public HomeController()
        {
      
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
            return View(new Movie());
        }

        public IActionResult DisplayMovie(Movie film) 
        {
            if (film.Genre == "Horror")
            {
                film.Genre = "Horror";
            }
            else if (film.Genre == "Comedy")
            {
                film.Genre = "Comedy";
            }
            else if (film.Genre == "Drama")
            {
                film.Genre = "Drama";
            }
            else if (film.Genre == "Romance")
            {
                film.Genre = "Romance";
            }
            else
            {
                film.Genre = "Sci-fi";
            }

            return View(film);
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
}
