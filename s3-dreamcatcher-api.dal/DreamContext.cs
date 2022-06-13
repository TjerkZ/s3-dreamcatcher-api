using Microsoft.EntityFrameworkCore;
using s3_dreamcatcher_api.dto;

namespace s3_dreamcatcher_api.dal
{
    public class DreamContext : DbContext
    {
        public DreamContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<DreamDTO>? Dreams { get; set; }
        public DbSet<TagDTO>? Tags { get; set; }
    }
}
