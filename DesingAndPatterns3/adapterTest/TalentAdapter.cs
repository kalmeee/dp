using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterTest
{
    class TalentAdapter : IPerformer
    {
        StarWanabee hoodedFigure;

        public TalentAdapter(StarWanabee hoodedFigure) {
            this.hoodedFigure = hoodedFigure;
        }

        public void dance()
        {
            hoodedFigure.stumble();
        }

        public void sing()
        {
            hoodedFigure.buzz();
        }

        public void tellAJoke()
        {
            hoodedFigure.unVail();
        }
    }
}
