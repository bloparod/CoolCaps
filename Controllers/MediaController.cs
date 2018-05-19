using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoolCaptions.Models;
using CoolCaptions.Controllers.Common;
using CoolCaptions.Services;

namespace CoolCaptions.Controllers
{
    public class MediaController : BaseController
    {
        private readonly MediaService mediaService;

        public MediaController()
        {
            this.mediaService = new MediaService();
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
