using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melos
{
    class RobotDirector
    {
        private RobotBuilder robotBuilder;

        public RobotDirector(RobotBuilder robotBuilder) {
            this.robotBuilder = robotBuilder;
        }

        public Robot getRobot() {
            return this.robotBuilder.getRobot();
        }

        public void makeRobot() {

            this.robotBuilder.buildRobotHead();
            this.robotBuilder.buildRobotTorso();
            this.robotBuilder.buildRobotArms();
            this.robotBuilder.buildRobotLegs();

        }
    }
}
