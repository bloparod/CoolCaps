using System;
using System.Collections.Generic;
using System.Linq;
using CoolCaptions.Models;

namespace CoolCaptions.Services
{
    public class MediaService
    {
        private const int MediaQty = 17;
        private readonly DifficultyLevelService difficultyLevelService;
        private IList<Media> allMedia;

        public MediaService()
        {
            this.difficultyLevelService = new DifficultyLevelService();

            this.SetAllMedia();
        }

        public Media Get(int mediaId)
        {
            return this.allMedia.SingleOrDefault(x => x.Id == mediaId);
        }

        public IEnumerable<Media> GetAll()
        {
            return this.allMedia.ToList();
        }

        public IEnumerable<Media> GetNew()
        {
            return this.allMedia
                .OrderBy(x => x.CreatedOn)
                .ToList();
        }

        public IEnumerable<Media> GetMostViewed()
        {
            return this.allMedia
                .OrderBy(x => x.ViewsQty)
                .ToList();
        }

        public IEnumerable<Media> GetTrending()
        {
            return this.GetMostViewed();
        }

        public IEnumerable<Media> GetRandom()
        {
            return this.allMedia
                .Select(x => new
                {
                    Random = Guid.NewGuid(),
                    Media = x
                })
                .OrderBy(x => x.Random)
                .Select(x => x.Media)
                .ToList();
        }

        private void SetAllMedia()
        {
            this.allMedia = new List<Media>();

            for (var i = 1; i <= MediaQty; i++)
            {
                var difficultyLevel = this.difficultyLevelService.Get((i % 3) + 1);
                var type = i % 3 == 0 ? "audio" : "video";

                var media = new Media
                {
                    Id = i,
                    Title = $"Vídeo {i}",
                    ViewsQty = i,
                    DifficultyLevel = difficultyLevel,
                    WordsQty = i + difficultyLevel.Name.Length + 100,
                    Type = type
                };

                this.allMedia.Add(media);
            };
        }
    }
}