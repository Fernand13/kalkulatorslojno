﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
   public class Addition : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
