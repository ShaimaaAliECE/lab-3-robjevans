using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(string dia, int score) : base(dia, score)
        {

        }


        public override void Display()
        {
            Console.WriteLine(this.Description + " is displayed");
        }
    }
}
