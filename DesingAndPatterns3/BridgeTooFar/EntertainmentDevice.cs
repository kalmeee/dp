using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTooFar
{
    abstract class EntertainmentDevice
    {
        public bool power = false;

        public int position = 1;

        public int volume = 50;


        public abstract void upButtonPressed();
        public abstract void downButtonPressed();


        public void togglePower() {
            if (power == false)
            {
                power = true;
            }
            else {
                power = false;
            }
        }

        public void volumeUpButtonPressed() {
            if (power == true)
            {
                volume++;
            }
        }

        public void volumeDownButtonPressed()
        {
            if (power == true)
            {
                volume++;
            }
        }
    }
}
