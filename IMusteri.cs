using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal interface IMusteri
    {
        // interface içerisindeki metotların erişim belirleyicileri ve bodyleri olmamalı.

        void kaydet();
        void sil();
        void guncelle();

    }
}
