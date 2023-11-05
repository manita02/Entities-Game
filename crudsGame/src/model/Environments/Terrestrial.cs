﻿using crudsGame.src.interfaces;
using crudsGame.src.model.Map.Terrains;
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
            System.Windows.Forms.MessageBox.Show("se puede mover en tierra");
            return terrain is Land;
        }

        public override string ToString()
        {
            return "Terrestrial";
        }
    }
}
