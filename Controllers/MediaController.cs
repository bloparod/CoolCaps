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
    public class MediaController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult MostViewed()
        {
            return View();
        }

        public IActionResult Trending()
        {
            return View();
        }

        public IActionResult Random()
        {
            return View();
        }
    }
}
