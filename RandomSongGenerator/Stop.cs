using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RandomSongGenerator
{
    class Stop
    {

        public Stop()
        {
            Thread thread = new Thread(new ThreadStart(Sleep));
            thread.Start();
        }

        public void Sleep()
        {
            Thread.Sleep(100);

        }










    }
}
