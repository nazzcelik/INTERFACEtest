using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class MySql : IMusteri
    {
        public void guncelle()
        {
            Console.WriteLine("MySql güncelledi.");
        }

        public void kaydet()
        {
            Console.WriteLine("MySql kaydetti.");
        }

        public void sil()
        {
            Console.WriteLine("MySql sildi.");
        }
    }
}
