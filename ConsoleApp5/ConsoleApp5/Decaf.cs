﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf ";
        }

        public override decimal cost()
        {
            return 150;
        }
    }
}
