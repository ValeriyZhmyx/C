﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast ";
        }

        public override decimal cost()
        {
            return 120;
        }
    }
}
