﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractCover cover;
        public Client(AbstractFactory factory)
        {
           
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();

        }
        public void Run()
        {
            bottle.Interact(water);
            cover.Interact(bottle);
        }
    }
}
