using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melos
{
    class OldRobotBuilder : RobotBuilder
    {
        private Robot robot;

        public OldRobotBuilder() {
            robot = new Robot();
        }

        public void buildRobotArms()
        {
            robot.setRobotArms("Blue Hands");
        }

        public void buildRobotHead()
        {
            robot.setRobotHead("Sajt fej");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("ruber legs");
        }

        public void buildRobotTorso()
        {
            robot.setRobotTorso("super torso");
        }

        public Robot getRobot()
        {
            return this.robot;
        }
    }
}
