using CoolCaptions.Models.Common;

namespace CoolCaptions.Models
{
    public class DifficultyLevel : Entity
    {
        public string Name { get; set; }

        public int Order { get; set; }
    }
}