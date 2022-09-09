using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class SqlServer : IMusteri
    {
        public void guncelle()
        {
            Console.WriteLine("Sql Server güncelledi.");
        }
        public void kaydet()
        {
            Console.WriteLine("Sql Server kaydetti.");
        }

        public void sil()
        {
            Console.WriteLine("Sql Server sildi.");
        }

    }
}
