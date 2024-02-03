using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {
        public MagicWand(string desct) : base(desct) {
        }
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }
    }
}
