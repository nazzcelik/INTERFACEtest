using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface'imizi implement eden classlarımızdan oluşturduğumuz örneği INTERFACE KARŞILAYABİLİR.

            MusteriController controller = new MusteriController();
            controller.MusteriEkle(new SqlServer());
            controller.MusteriSil(new MySql());
            controller.MusteriGuncelle(new Oracle());

            Console.ReadLine();
        }
    }
}
