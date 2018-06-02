using CoolCaptions.Models;
using Microsoft.EntityFrameworkCore;

namespace CoolCaptions.DataAccess
{
    public class CoolCaptionsDatabase : DbContext
    {
        public CoolCaptionsDatabase(DbContextOptions<CoolCaptionsDatabase> options) : base(options) { }

        public DbSet<Media> Media { get; set; }

        public DbSet<DifficultyLevel> DifficultyLevel { get; set; }
    }
}