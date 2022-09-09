using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class Oracle : IMusteri
    {
        public void guncelle()
        {
            Console.WriteLine("Oracle güncelledi.");
        }

        public void kaydet()
        {
            Console.WriteLine("Oracle kaydetti.");
        }

        public void sil()
        {
            Console.WriteLine("Oracle sildi.");
        }
    }
}
