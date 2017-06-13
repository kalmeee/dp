using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sajt;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipFactory factory = new ShipFactory();
            Ship bs = factory.makeShip(1);
            Ship ts = factory.makeShip(2);

            Console.WriteLine(bs.weaponsystem.fire());
            Console.WriteLine(bs.weaponsystem.reload());

            Console.WriteLine(ts.weaponsystem.fire());
            Console.WriteLine(ts.weaponsystem.reload());
            
            Console.ReadLine();
        }
    }
}
