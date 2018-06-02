using System;
using System.Collections.Generic;
using System.Linq;
using CoolCaptions.DataAccess;
using CoolCaptions.Models;

namespace CoolCaptions.Services
{
    public class MediaService
    {
        private const int MediaQty = 17;

        private readonly DifficultyLevelService difficultyLevelService;
        private readonly CoolCaptionsDatabase database;

        public MediaService(
            DifficultyLevelService difficultyLevelService,
            CoolCaptionsDatabase database)
        {
            this.difficultyLevelService = difficultyLevelService;
            this.database = database;
        }

        public Media Get(int mediaId)
        {
            return this.database.Media.SingleOrDefault(x => x.Id == mediaId);
        }

        public IEnumerable<Media> GetAll()
        {
            return this.database.Media.ToList();
        }

        public IEnumerable<Media> GetNew()
        {
            return this.database.Media
                .OrderByDescending(x => x.CreatedOn)
                .ToList();
        }

        public IEnumerable<Media> GetMostViewed()
        {
            return this.database.Media
                .OrderBy(x => x.ViewsQty)
                .ToList();
        }

        public IEnumerable<Media> GetTrending()
        {
            return this.GetMostViewed();
        }

        public IEnumerable<Media> GetRandom()
        {
            return this.database.Media
                .Select(x => new
                {
                    Random = Guid.NewGuid(),
                    Media = x
                })
                .OrderBy(x => x.Random)
                .Select(x => x.Media)
                .ToList();
        }
    }
}