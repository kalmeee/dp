using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterTest
{
    class StarWanabee
    {

        public StarWanabee() { }


        public void buzz() {
            Console.WriteLine("BUZZZZZZZZZ");
            Console.ReadKey();
        }

        public void stumble()
        {
            Console.WriteLine("Stumbles and falls head first");
            Console.ReadKey();
        }

        public void unVail()
        {
            Console.WriteLine("ZZ zZ z Zz zZ (I was a bee all along)");
            Console.ReadKey();
        }


    }
}
