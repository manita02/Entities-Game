﻿using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Terrains
{
    internal class Water:ITerrain
    {
        private Color color = Color.LightBlue;
        public Color getColor()
        {
            return color;
        }

        public override string ToString()
        {
            return "Water";
        }
    }
}
