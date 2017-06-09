using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterTest
{
    class Program
    {
        static void Main(string[] args)
        {

            IPerformer star = new GigaStar();

            IPerformer notAStar = new TalentAdapter(new StarWanabee());



            star.sing();
            star.dance();
            star.tellAJoke();

            notAStar.dance();
            notAStar.sing();
            notAStar.tellAJoke();
        }
    }
}
