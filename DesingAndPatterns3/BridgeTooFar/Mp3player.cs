using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTooFar
{
    class Mp3player : EntertainmentDevice
    {
        public override void downButtonPressed()
        {
            Console.WriteLine("prev song");
        }

        public override void upButtonPressed()
        {
            Console.WriteLine("next song");
        }
    }
}
