using Microsoft.EntityFrameworkCore;
using RegistroPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersonas.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Persona>Persona { get; set; }
        protected   override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DATA\RegistroPersonas.db");
        }
    }
  
}
