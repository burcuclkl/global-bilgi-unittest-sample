using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace global_bilgi_unittest_sample.Models.DISample2
{
    public class Dashboard
    {

        IProgress _progress;

        public Dashboard(IProgress progress)
        {
            _progress = progress;
        }

        public void Init()
        {
            _progress.Start();
            _progress.Continue();
            _progress.End();
        }
    }
}
