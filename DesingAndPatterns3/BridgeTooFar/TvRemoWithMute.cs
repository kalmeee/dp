using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTooFar
{
    class TvRemoWithMute : Remote
    {
        public TvRemoWithMute(EntertainmentDevice device) : base(device)
        {
        }

        public override void bigButtonPressed()
        {
            device.volume = 0;   
        }
    }
}
