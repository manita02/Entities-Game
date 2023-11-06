using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Map.Terrains
{
    internal class Water : ITerrain
    {
        private Color color = Color.DeepSkyBlue;

        public Color GetColor()
        {
            return color;
        }

        public override string ToString()
        {
            return "Water";
        }
    }
}
