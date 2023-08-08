using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Wissenprojesikatalog.DAL.EntitiyConfig.Abstract;
using Wissenprojesikatalog.Entites.Abstract;
using Wissenprojesikatalog.Entites.Constract;

namespace Wissenprojesikatalog.DAL.EntitiyConfig.Concrete
{
    public class BirimConfig: BaseConfig<Birim>
    {
        public override void Configure(EntityTypeBuilder<Birim>builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.BirimAdi).HasMaxLength(50);

            //ayni birimden ikinci kayıt olmasın

            builder.HasIndex(p=> p.BirimAdi).IsUnique();    

        }
        
    }
}
