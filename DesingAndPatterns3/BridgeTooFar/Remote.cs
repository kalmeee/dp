using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTooFar
{
    abstract class Remote
    {
        public EntertainmentDevice device;

        public Remote(EntertainmentDevice device) {
            this.device = device;
        }

        public void powerButonPressed() {
            device.togglePower();
        }

        public void downButtonPressed() {
            device.downButtonPressed();
        }

        public void upButtonPressed()
        {
            device.upButtonPressed();
        }

        public abstract void bigButtonPressed();
    }
}
