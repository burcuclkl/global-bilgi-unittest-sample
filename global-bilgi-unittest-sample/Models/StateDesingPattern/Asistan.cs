using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace global_bilgi_unittest_sample.Models.StateDesingPattern
{
    public class Asistan
    {
        IMode _mode;

        public Asistan()
        {
            this._mode = new GunduzMode();
        }


        public void ChangeMode(IMode mode)
        {
            //business....
            this._mode = mode;
        }


        public void Answer()
        {
            this._mode.Answer();
        }

    }
}
