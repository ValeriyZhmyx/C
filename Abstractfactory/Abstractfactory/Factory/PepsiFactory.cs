using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }
    }
}
