using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTooFar
{
    class OtherTvRemote : Remote
    {
        public OtherTvRemote(EntertainmentDevice device) : base(device)
        {
        }

        public override void bigButtonPressed()
        {
            device.position += 20;
            Console.WriteLine("Position set to " + device.position);
        }
    }
}
