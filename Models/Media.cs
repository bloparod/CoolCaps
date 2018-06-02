using System;
using CoolCaptions.Models.Common;

namespace CoolCaptions.Models
{
    public class Media : Entity
    {
        public string Title { get; set; }

        public DateTime CreatedOn { get; set; }

        public int ViewsQty { get; set; }

        public virtual DifficultyLevel DifficultyLevel { get; set; }

        public int WordsQty { get; set; }

        public string Type { get; set; }

        public string FileName { get; set; }

        public string MimeType { get; set; }
    }
}