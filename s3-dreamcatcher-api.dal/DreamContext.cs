using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using s3_dreamcatcher_api.dal.DB_Models;

namespace s3_dreamcatcher_api.dal
{
    public class DreamContext : DbContext
    {
        public DreamContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Dream>? Dreams { get; set; }
        public DbSet<Tag>? Tags { get; set; }
    }
}
