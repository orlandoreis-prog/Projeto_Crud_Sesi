using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFiebSesi.Models;

namespace ProjetoFiebSesi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        { }

        public DbSet<Colaborador> Colaboradors { get; set; }
        }
    }
