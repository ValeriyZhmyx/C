﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractCover CreateCover();
    }
}
