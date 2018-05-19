using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoolCaptions.Models;

namespace CoolCaptions.Controllers
{
    public class YourMediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Playlists()
        {
            return View();
        }

        public IActionResult Favorites()
        {
            return View();
        }
    }
}
