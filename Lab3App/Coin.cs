using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int Value;
        public Coin(string name, int score, int value) : base(name, score)
        {
            //this.Description = name; // is this needed?
            this.Value = value;


        }
        public void UpdateTotalValue()
        {
            brd.TotalValue += this.Value;
            Console.WriteLine("Total Value is updated to: " + brd.TotalValue);
        }
        public override void AddMe(List<Collectable> tester)
        {
            base.AddMe(tester);
            UpdateTotalValue();
        }
        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
    }
}
