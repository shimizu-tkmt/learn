using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleAPIApp.Models;

namespace SampleReactAPI.Data
{
    public class SampleReactAPIContext : DbContext
    {
        public SampleReactAPIContext (DbContextOptions<SampleReactAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SampleAPIApp.Models.Product> Product { get; set; } = default!;
    }
}
