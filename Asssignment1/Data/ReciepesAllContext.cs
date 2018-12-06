using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Asssignment1.Models
{
    public class ReciepesAllContext : DbContext
    {
        public ReciepesAllContext (DbContextOptions<ReciepesAllContext> options)
            : base(options)
        {
        }

        public DbSet<Asssignment1.Models.ReciepeModel> ReciepeModel { get; set; }
    }
}
