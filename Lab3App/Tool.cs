using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Tool : Collectable
    {

        public Tool(string desc) : base(desc) { 
        
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            this.DoAction();
        }

        public override void Display()
        {

        }

        public virtual void DoAction()
        {
            
        }
    }
}
