using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy
{
    internal class IncreasesAttackPoints : IStrategyTypeOfItem
    {
        Random random = new Random();
        public void ApplyItem(Entity entity)
        {
            entity.attackPoints += random.Next(10, 50);
        }

        public override string ToString()
        {
            return "Increases Attack Points";
        }
    }
}
