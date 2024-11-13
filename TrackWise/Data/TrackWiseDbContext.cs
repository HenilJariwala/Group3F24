using Microsoft.EntityFrameworkCore;
using Group3F24.TrackWise.Model;

namespace TrackWise.Data
{
    public class TrackWiseDbContext : DbContext
    {
        public TrackWiseDbContext(DbContextOptions<TrackWiseDbContext> options)
            : base(options)
        {
        }

        public DbSet<RegisterModel> Users { get; set; }
    }
}
