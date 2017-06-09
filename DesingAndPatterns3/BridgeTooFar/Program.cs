using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTooFar
{
    class Program
    {
        static void Main(string[] args)
        {

            Remote tvMute = new TvRemoWithMute(new Tv());
            Remote tvChanelJumper = new OtherTvRemote(new Tv());

            tvMute.powerButonPressed();
            tvMute.upButtonPressed();
            tvMute.bigButtonPressed();

            tvChanelJumper.powerButonPressed();
            tvChanelJumper.upButtonPressed();
            tvChanelJumper.bigButtonPressed();

            Console.ReadLine();
        }
    }
}
