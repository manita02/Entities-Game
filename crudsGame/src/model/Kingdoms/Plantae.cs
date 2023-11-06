using crudsGame.src.interfaces;
using crudsGame.src.model.Foods.Diets;
using crudsGame.src.model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Kingdoms
{
    internal class Plantae:IKingdom
    {
        public bool CanInteract(Item item)
        {
            return item.kingdom is Plantae; 

        }

        public override string ToString()
        {
            return "Plantae";
        }
    }
}
