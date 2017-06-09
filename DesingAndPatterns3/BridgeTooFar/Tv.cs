using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTooFar
{
    class Tv : EntertainmentDevice
    {
        public override void downButtonPressed()
        {
            position--;
            Console.WriteLine("chanel switched to: " + position);
            
        }

        public override void upButtonPressed()
        {
            position++;
            Console.WriteLine("chanel switched to: " + position);
            
        }
    }
}
