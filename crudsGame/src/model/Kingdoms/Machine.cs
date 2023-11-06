using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Kingdoms
{
    internal class Machine:IKingdom
    {
        public bool CanInteract(Item item)
        {
            return item.kingdom is Machine; 

        }

        public override string ToString()
        {
            return "Machine";
        }
    }
}
