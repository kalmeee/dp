using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melos
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotBuilder oldRobot = new OldRobotBuilder();

            RobotDirector robotDirector = new RobotDirector(oldRobot);

            robotDirector.makeRobot();

            Robot firstBot = robotDirector.getRobot();

            Console.WriteLine(firstBot);
            Console.ReadKey();
        }
    }
}
