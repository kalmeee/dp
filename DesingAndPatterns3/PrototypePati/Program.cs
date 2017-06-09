using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePati
{
    class Program
    {
        static void Main(string[] args)
        {

            Player og = new Player();
            og.Opponent = new Opponent();

            Console.WriteLine($"{og.getStatInfo()}  opponent: {og.Opponent.GetHashCode()}");
            og.Health = 50;
            Player shallowClone = og.ShallowCopy();
            Player deepClone = (Player) og.Clone();


            Console.WriteLine($"{og.getStatInfo()}  opponent: {og.Opponent.GetHashCode()}");
            Console.WriteLine($"{shallowClone.getStatInfo()}  opponent: {shallowClone.Opponent.GetHashCode()}");
            Console.WriteLine($"{deepClone.getStatInfo()}  opponent: {deepClone.Opponent.GetHashCode()}");
            Console.ReadLine();




        }
    }
}
