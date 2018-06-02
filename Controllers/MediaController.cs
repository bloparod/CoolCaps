using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CoolCaptions.Controllers.Common;
using CoolCaptions.Models;
using CoolCaptions.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoolCaptions.Controllers
{
    public class MediaController : BaseController
    {
        private readonly MediaService mediaService;

        public MediaController(MediaService mediaService)
        {
            this.mediaService = mediaService;
        }

        public IActionResult Explore()
        {
            this.SetTitle("Explorar");

            var medias = this.mediaService.GetAll();

            return View("MediaList", medias);
        }

        public IActionResult New()
        {
            this.SetTitle("Nuevos");

            var medias = this.mediaService.GetNew();

            return View("MediaList", medias);
        }

        public IActionResult MostViewed()
        {
            this.SetTitle("Más vistos");

            var medias = this.mediaService.GetMostViewed();

            return View("MediaList", medias);
        }

        public IActionResult Trending()
        {
            this.SetTitle("Tendencias");

            var medias = this.mediaService.GetTrending();

            return View("MediaList", medias);
        }

        public IActionResult Random()
        {
            this.SetTitle("Random");

            var medias = this.mediaService.GetRandom();

            return View("MediaList", medias);
        }

        public IActionResult Play(int id)
        {
            var media = this.mediaService.Get(id);

            return View(media);
        }
    }
}