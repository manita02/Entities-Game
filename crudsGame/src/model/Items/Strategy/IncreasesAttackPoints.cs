using crudsGame.src.interfaces;
using crudsGame.src.model.Kingdoms;
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
        public bool ApplyItem(Entity entity)
        {
            try
            {
                if (entity.attackPoints != 80)
                {
                    entity.currentEnergy -= 10;
                    MessageBox.Show("The " + entity.name + " creature has used a item that increased its attack points!!");
                    entity.attackPoints += random.Next(5, 15);
                    return true;
                }
                else
                {
                    MessageBox.Show("Su entidad tiene lo maximo que puede obtener en puntos de ataque");
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
            return "Increases Attack Points";
        }
    }
}
