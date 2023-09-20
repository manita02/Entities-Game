using crudsGame.src.model;
using crudsGame.src.model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.interfaces
{
    public interface IKingdom
    {
        bool CanInteract(Entity entity, Item item);
    }
}
