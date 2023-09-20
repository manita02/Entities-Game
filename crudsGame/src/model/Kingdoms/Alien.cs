using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Kingdoms
{
    internal class Alien:IKingdom
    {
        public bool CanInteract(Entity entity, Item item)
        {
            if (entity.kingdom.ToString() == item.kingdom.ToString())
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Alien";
        }
    }
}
