using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterTest
{
    class GigaStar : IPerformer
    {
        public void dance()
        {
            Console.WriteLine("Starts to dance, it mesmerises the audiance");
            Console.ReadKey();
        }

        public void sing()
        {
            Console.WriteLine("Sings a song so wonderful it makes even Miki cry");
            Console.ReadKey();

        }

        public void tellAJoke()
        {
            Console.WriteLine("After a well told joke the audiance burst out in laugter");
            Console.ReadKey();

        }
    }
}
