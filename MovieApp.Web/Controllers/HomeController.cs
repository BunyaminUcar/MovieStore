﻿using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filmBasligi= "film başlığı";
            string filmAciklama="filmin açıklaması";
            string filmYonetmen ="filmin yönetmen adı";
            string[] oyuncular ={ "oyuncu 1", "oyuncu 2","oyuncu 3" };


            var m = new Movie();

            m.Title = filmBasligi;
            m.Description = filmAciklama;
            m.Director = filmYonetmen;
            m.Players = oyuncular;
            m.ImageURL = "reacher.jpg";

            return View(m);
        }
        public IActionResult About()
        {

           

            return View();
        }
    
    }
}
