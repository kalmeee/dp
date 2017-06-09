using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingAndPatterns3
{
    class ChaosShipFactory : IShipFactory
    {
        public ITrade getTrade()
        {
            return new Lunar();
        }

        public IWar getWar()
        {
            return new Khorny();
        }
    }
}
