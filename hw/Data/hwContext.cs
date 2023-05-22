using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hw.Models;

namespace hw.Data
{
    public class hwContext : DbContext
    {
        public hwContext (DbContextOptions<hwContext> options)
            : base(options)
        {
        }

        public DbSet<hw.Models.Movie> Movie { get; set; } 
    }
}
