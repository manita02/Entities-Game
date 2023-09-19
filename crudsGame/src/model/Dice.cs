using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model
{
    static class Dice
    {
        static Random RandomSide = new Random();
        public static int TrowDice()
        {
            return RandomSide.Next(1, 6);
        }
    }
}
