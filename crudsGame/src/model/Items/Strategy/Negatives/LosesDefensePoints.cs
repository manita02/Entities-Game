using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy.Negatives
{
    internal class LosesDefensePoints:IStrategyTypeOfItem
    {
        Random random = new Random();
        public bool ApplyItem(Entity entity)
        {
            try
            {
                if (entity.defensePoints != 0)
                {
                    entity.currentEnergy -= 10;
                    MessageBox.Show("The " + entity.name + " creature used an item that made him lose defense points!!");
                    entity.defensePoints -= random.Next(5, 15);
                    return true;
                }
                else
                {
                    MessageBox.Show("Su entidad perdió todos sus puntos de defensa");
                    return true;
                }
            }
            catch
            {
                return true;

            }
            
        }

        public override string ToString()
        {
            return "Loses Defense Points";
        }
    }
}
