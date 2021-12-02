using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimOdevUygulama
{
    public class baseClass
    {
        public static int sayac = 1; //ilk oluştuğu zaman 1 değerini otomatik olarak alsın.

        private int _id;
        public int id
        {
            get
            {
                return _id;
            }

            private set
            {
                // bir sayaç içerisindeki değerden faydalanmak istiyoruz.
                //_id = sayac;
                //sayac = sayac + 1;
                //nedeni basit set alanı private olarak işaretlendi..
            }
        }

        public baseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }

        private string _barkod;
        public string barkod { get; set; }//TODO: Buraya geri dön

        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }

        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }

    }
}
