using System.Xml;
using Wissenprojesikatalog.Entites.Abstract;

namespace Wissenprojesikatalog.Entites.Constract
{
    public class Urun : BaseEntity
    {
        public string UrunAdi { get; set; }

        public string UrunKodu { get; set; }    

        public string? Aciklama { get; set; }

        public Double? Miktar {get; set; }  

        public Double? Fiyat { get; set; }

    
        
        
        #region Diger Entity'lerle olan iliskilendirmeler
        public int KategoriId { get; set; }

        public Kategori? Kategori { get; set; }

        public int? BirimId { get; set; }

        public Birim? Birim { get; set; }
        #endregion
    }
}