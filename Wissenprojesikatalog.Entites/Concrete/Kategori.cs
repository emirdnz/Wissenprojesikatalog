using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wissenprojesikatalog.Entites.Abstract;

namespace Wissenprojesikatalog.Entites.Constract
{
    public class Kategori : BaseEntity
    {
        public string KategoriAdi { get; set; }

        public string? Aciklama { get; set; }

        public ICollection <Urun>? Urunler { get; set; }


    }
}
