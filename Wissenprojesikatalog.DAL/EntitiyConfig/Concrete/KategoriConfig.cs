using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wissenprojesikatalog.DAL.EntitiyConfig.Abstract;
using Wissenprojesikatalog.Entites.Constract;

namespace Wissenprojesikatalog.DAL.EntitiyConfig.Concrete
{
    public class KategoriConfig:BaseConfig<Kategori>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => p.KategoriAdi).IsUnique();
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
            builder.Property(p => p.Aciklama).HasMaxLength(100);
        }
    }
}
