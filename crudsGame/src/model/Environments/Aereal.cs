using crudsGame.src.interfaces;
using crudsGame.src.model.Map.Terrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Environments
{
    internal class Aereal : IEnvironment
    {
        public bool CanMoveThrough(ITerrain terrain)
        {
            if (terrain is Water || terrain is Land)
            {
                return true;
            }
            return false;     
        }

        public override string ToString()
        {
            return "Aereal";
        }
    }
}
