using Wissenprojesikatalog.Entites.Abstract;

namespace Wissenprojesikatalog.Entites.Constract
{
    public class Birim : BaseEntity
    {
        public string BirimAdi { get; set; }        

        public IList<Urun>? Urunler { get; set; }   
    }
}