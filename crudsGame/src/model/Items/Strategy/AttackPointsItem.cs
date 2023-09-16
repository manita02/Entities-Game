using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy
{
    internal class AttackPointsItem : IInteractuable
    {
        public void Interact(IEntity entity, int value)
        {
            entity.AttackPoints += value; //mostrar a mauro dudas
        }

        public override string ToString()
        {
            return "Affects Attack Points";
        }
    }
}
