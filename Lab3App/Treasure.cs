using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        public int Score;
        public Treasure(string desc, int score) : base(desc)
        {
            Score = score;
        }
        public void UpdateTotalScore()
        { 
            Brd.TotalScore += this.Score;
            Console.WriteLine("Total Score is updated to: " +  Brd.TotalScore);
        }
        public override void Display()
        {

        }
        public override void AddMe(List<Collectable> a)
        {
            base.AddMe(a);
            this.UpdateTotalScore();

        }
    }
}
