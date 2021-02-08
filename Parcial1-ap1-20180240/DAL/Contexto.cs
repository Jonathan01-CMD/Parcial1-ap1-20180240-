using Microsoft.EntityFrameworkCore;
using Parcial1_ap1_20180240.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_ap1_20180240.Dal
{
    public class Contexto : DbContext
    {
        public DbSet<Ciudades> Ciudades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = RegistroCiudades.Db");
        }
    }
}
