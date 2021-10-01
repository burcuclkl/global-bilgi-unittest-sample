using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace global_bilgi_unittest_sample.Models.DISample2
{
    public interface IProgress
    {
        void Start();

        void Continue();

        void End();


    }
}
