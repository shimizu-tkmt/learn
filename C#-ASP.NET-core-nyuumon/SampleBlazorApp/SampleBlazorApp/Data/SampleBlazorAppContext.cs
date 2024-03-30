using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleBlazorApp.Models;

namespace SampleBlazorApp.Data
{
    public class SampleBlazorAppContext : DbContext
    {
        public SampleBlazorAppContext (DbContextOptions<SampleBlazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<SampleBlazorApp.Models.Person> Person { get; set; } = default!;
    }
}
