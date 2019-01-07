using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProje
{
   public class Kisi
    {
        
        private string Adsoyad; //bu class içinde kullanılır
        internal int Yas { get; set; } //internal sadece bu proje içerisinde kullanılabilir.

        public int Id { get; set; } 
        public string Ad { get; set; }
        public string Soyad { get; set; }
        protected internal int KrediKartNo { get; set; } //protected internal kendi projesinde public gibi davranır, başka projelerde protected gibi davranır.
        protected int TcKimlik { get; set; } //inherit alan claslarda kullanılabilir.erişilebilir.
        public string FullName()
        {
            //return this.Ad + this.Soyad;
            Adsoyad = this.Ad + this.Soyad;
            return Adsoyad;
        }
    }
}
