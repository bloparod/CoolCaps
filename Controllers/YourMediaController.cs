using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoolCaptions.Models;
using CoolCaptions.Controllers.Common;

namespace CoolCaptions.Controllers
{
    public class YourMediaController : BaseController
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
