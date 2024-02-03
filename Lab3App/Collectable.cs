using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string Description;
        public CollectionBoard Brd;
        public Collectable(string desc) {
            this.Description = desc;
        }
        public virtual void AddMe(List<Collectable> list)
        {
            if (!(list.Contains(this)))
            {
                list.Add(this);
                Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            }
            else if ((list.Contains(this)))
            {
                list.Remove(this);
                Console.WriteLine(this.Description + " Removed.");
            }
        }
    }
}

