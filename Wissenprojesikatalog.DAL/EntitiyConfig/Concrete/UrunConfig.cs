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
    public class UrunConfig : BaseConfig<Urun>
    {
        public override void Configure(EntityTypeBuilder<Urun> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.UrunAdi).HasMaxLength(100);
            builder.Property(p => p.Aciklama).HasMaxLength(200);
            builder.Property(p => p.UrunKodu).HasMaxLength(100);
            builder.HasIndex(p => p.UrunKodu).IsUnique();
        } 
        } 
}

