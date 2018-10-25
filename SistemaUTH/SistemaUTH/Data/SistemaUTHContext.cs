using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaUTH.Models
{
    public class SistemaUTHContext : DbContext
    {
        public SistemaUTHContext (DbContextOptions<SistemaUTHContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaUTH.Models.Categoria> Categoria { get; set; }
    }
}
