using crudsGame.src.interfaces;
using crudsGame.src.model.Terrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Environments
{
    internal class Aquatic : IEnvironment
    {
        public bool CanMoveThrough(ITerrain terrain)
        {
            return terrain is Water;
        }

        public override string ToString()
        {
            return "Aquatic";
        }
    }
}
