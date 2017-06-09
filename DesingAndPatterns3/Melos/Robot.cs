using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melos
{
    class Robot : RobotPlan
    {
        private String head;
        private String torso;
        private String legs;
        private String arms;


        public void setRobotArms(string arms)
        {
            this.arms = arms;
        }

        public void setRobotHead(string head)
        {
            this.head = head;
        }

        public void setRobotLegs(string legs)
        {
            this.legs = legs;
        }

        public void setRobotTorso(string torso)
        {
            this.torso = torso;
        }
    }
}
