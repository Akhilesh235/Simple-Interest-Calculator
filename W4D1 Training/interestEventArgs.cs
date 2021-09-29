using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1_Training
{
    class interestEventArgs : EventArgs
    {
        public double simpleinterest { get; private set; }

        public interestEventArgs( double something)
        {
            simpleinterest = something;
        }
    }
}
