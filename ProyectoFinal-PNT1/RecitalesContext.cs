using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal_PNT1
{
    internal class RecitalesContext : DbContext 
    {
        public DbSet<Recital> recitales { get; set; }
        public DbSet<Banda> bandas { get; set; }
        public DbSet<Ticket> tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=GRECO\SQLEXPRESS;Database=ProyectoRecitales ;Trusted_Connection=True;");
        }
    }
}
