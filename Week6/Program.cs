﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            PassByValue num = new PassByValue();
            int bnum = 7;

            num.Calculate(bnum);
        }
    }
}
