using System;
using CoolCaptions.Models.Common;

namespace CoolCaptions.Models
{
    public class Media : Entity
    {
        public string Title { get; set; }

        public DateTime CreatedOn { get; set; }

        public int ViewsQty { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public int WordsQty { get; set; }

        public string Type { get; set; }
    }
}