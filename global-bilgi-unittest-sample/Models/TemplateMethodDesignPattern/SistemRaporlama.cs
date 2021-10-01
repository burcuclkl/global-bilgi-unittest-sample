using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace global_bilgi_unittest_sample.Models.TemplateMethodDesignPattern
{
    public abstract class SistemRaporlama
    {

        public void IstatistikTopla()
        {

        }

        public void Hesapla()
        {

        }

        public void KisileriHazirla()
        {

        }

        public abstract void RaporYaz();


        public void RaporHazirla()
        {
            IstatistikTopla();
            Hesapla();
            KisileriHazirla();
            RaporYaz();
        }


    }
}
