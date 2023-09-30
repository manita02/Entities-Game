using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy.Negatives
{
    internal class LosesAttackPoints:IStrategyTypeOfItem
    {
        Random random = new Random();
        public bool ApplyItem(Entity entity)
        {
            try
            {
                //MessageBox.Show("ataque: " + entity.attackPoints);
                if (entity.attackPoints != 0)
                {

                    entity.currentEnergy -= 10;
                    MessageBox.Show("The " + entity.name + " creature used an item that made him lose attack points!!");
                    entity.attackPoints -= random.Next(5, 15);
                    return true;
                }
                else
                {
                    MessageBox.Show("Su entidad perdió todos sus puntos de ataque!!");
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
            return "Loses Attack Points";
        }
    }
}
