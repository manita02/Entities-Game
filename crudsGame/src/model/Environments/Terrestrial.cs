﻿using crudsGame.src.interfaces;
using crudsGame.src.model.Terrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Environments
{
    internal class Terrestrial : IEnvironment
    {
        public bool CanMoveThrough(ITerrain terrain)
        {
            /*
            if (terrain is Terrestrial)
            {
                return terrain;
            }
            throw new Exception("no se puede");
            */
            MessageBox.Show("se puede mover en tierra");
            return terrain is Land;
        }

        public override string ToString()
        {
            return "Terrestrial";
        }
    }
}
