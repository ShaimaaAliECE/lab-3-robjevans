﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool
    {
        public Axe(string a) : base(a)
        {

        }
        public override void DoAction()
        {
            Console.WriteLine("Axe is used");
        }
    }
}
