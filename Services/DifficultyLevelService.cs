using System;
using System.Collections.Generic;
using System.Linq;
using CoolCaptions.DataAccess;
using CoolCaptions.Models;

namespace CoolCaptions.Services
{
    public class DifficultyLevelService
    {
        private readonly CoolCaptionsDatabase database;

        public DifficultyLevelService(CoolCaptionsDatabase database)
        {
            this.database = database;
        }

        public DifficultyLevel Get(int difficultyLevelId)
        {
            return this.database.DifficultyLevel.SingleOrDefault(x => x.Id == difficultyLevelId);
        }

        public IEnumerable<DifficultyLevel> GetAll()
        {
            return this.database.DifficultyLevel.ToList();
        }
    }
}