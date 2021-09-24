using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsRsvp.Models
{
    public class PauloDbContext : DbContext
    {
        public PauloDbContext(DbContextOptions<PauloDbContext> options) : base(options)
        {
        }

        public DbSet<Confirmacao> Confirmacoes { get; set; }
    }
}
