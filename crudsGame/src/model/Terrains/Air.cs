﻿using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Terrains
{
    internal class Air:ITerrain
    {
        private Color color = Color.Red;
        public Color getColor()
        {
            return color;
        }

        public override string ToString()
        {
            return "Air";
        }
    }
}
