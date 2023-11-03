using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Terrains
{
    internal class Land:ITerrain
    {
        private Color color = Color.LimeGreen;
        public Color getColor()
        {
            return color;
        }

        public bool CanMoveThrough(ITerrain terrain)
        {
            return terrain is Land;
        }

        public override string ToString()
        {
            return "Land";
        }
    }
}
