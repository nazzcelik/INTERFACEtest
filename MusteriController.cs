using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class MusteriController
    {
        public void MusteriEkle(IMusteri veritabani)
        {
            veritabani.kaydet();
        }
        public void MusteriGuncelle(IMusteri veritabani2)
        {
            veritabani2.guncelle();
        }
        public void MusteriSil(IMusteri veritabani3)
        {
            veritabani3.sil();
        }
    }
}
