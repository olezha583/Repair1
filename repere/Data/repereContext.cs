using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using repere.models;

namespace repere.Data
{
    public class repereContext : DbContext
    {
        public repereContext (DbContextOptions<repereContext> options)
            : base(options)
        {
        }

        public DbSet<repere.models.Client> Client { get; set; } = default!;
        public DbSet<repere.models.Request> Request { get; set; } = default!;
        public DbSet<repere.models.Service> Service { get; set; } = default!;
        public DbSet<repere.models.Staff> Staff { get; set; } = default!;
    }
}
