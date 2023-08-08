using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Wissenprojesikatalog.Entites.Constract;

namespace Wissenprojesikatalog.DAL.context
{
    public class SqlDbContext : DbContext

    {

        public DbSet<Birim> Birimler { get; set; }

        public DbSet <Kategori> Kategoriler { get; set; }

        public DbSet<Urun> Urunler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.; Database=WissenKatalogProjesi; Trusted_Connection=true;TrusServerCertificate=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Birim>().Property(p=>p.BirimAdi).HasMaxLength(50); //1. yöntem

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  //2.yöntem  
        }

    }
}
