using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingAndPatterns3
{
    class ImperialShipFactory : IShipFactory
    {
        public ITrade getTrade()
        {
            return new Falcon();
        }

        public IWar getWar()
        {
            return new Fury();
        }
    }
}
