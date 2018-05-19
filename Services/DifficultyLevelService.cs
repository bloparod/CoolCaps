using System;
using System.Collections.Generic;
using System.Linq;
using CoolCaptions.Models;

namespace CoolCaptions.Services
{
    public class DifficultyLevelService
    {
        private IList<DifficultyLevel> all;

        public DifficultyLevelService()
        {
            this.SetAllDifficultyLevels();
        }

        public DifficultyLevel Get(int difficultyLevelId)
        {
            return this.all.SingleOrDefault(x => x.Id == difficultyLevelId);
        }

        public IEnumerable<DifficultyLevel> GetAll()
        {
            return this.all.ToList();
        }

        private void SetAllDifficultyLevels()
        {
            this.all = new List<DifficultyLevel>();

            this.all.Add(new DifficultyLevel
            {
                Id = 1,
                Name = "Fácil",
                Order = 1
            });

            this.all.Add(new DifficultyLevel
            {
                Id = 2,
                Name = "Intermedio",
                Order = 2
            });

            this.all.Add(new DifficultyLevel
            {
                Id = 3,
                Name = "Avanzado",
                Order = 3
            });
        }
    }
}