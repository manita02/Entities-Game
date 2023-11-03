using crudsGame.src.interfaces;
using crudsGame.src.model.Terrains;
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
            /*
            if(terrain is Aquatic || terrain is Land)
            {
                return terrain;
            }
            throw new Exception("no se puede");
            */
            if (terrain is Water || terrain is Land)
            {
                MessageBox.Show("se puede mover en aireeee");
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
