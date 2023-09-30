using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy
{
    internal class IncreasesDefensePoints : IStrategyTypeOfItem
    {
        Random random = new Random();
        public bool ApplyItem(Entity entity)
        {
            try
            {
                if (entity.defensePoints != 80)
                {
                    entity.currentEnergy -= 10;
                    MessageBox.Show("The " + entity.name + " creature has used a item that increased its defense points!!");
                    entity.defensePoints += random.Next(5, 15);
                    return true;
                }
                else
                {
                    MessageBox.Show("Su entidad tiene lo maximo que puede obtener en puntos de defensa");
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
            return "Increases Defense Points";
        }
    }
}
