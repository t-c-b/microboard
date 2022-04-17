#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class MicroboardContext : DbContext
    {
        public MicroboardContext (DbContextOptions<MicroboardContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
    }
