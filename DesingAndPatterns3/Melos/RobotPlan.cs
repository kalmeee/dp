using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melos
{
    interface RobotPlan
    {
        void setRobotHead(String head);

        void setRobotTorso(String torso);

        void setRobotArms(String arms);

        void setRobotLegs(String legs);
    }
}
