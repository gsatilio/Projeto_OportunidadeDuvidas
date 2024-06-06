using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Duvidas.Data
{
    public class DuvidasContext : DbContext
    {
        public DuvidasContext (DbContextOptions<DuvidasContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Duvidas> Duvidas { get; set; } = default!;
    }
}
