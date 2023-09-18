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
        public void ApplyItem(Entity entity)
        {
            if (entity.defensePoints != 80)
            {
                entity.currentEnergy -= 10;
                MessageBox.Show("The " + entity.name + " creature has used a item that increased its defense points!!");
                entity.defensePoints += random.Next(5, 15);    
            }
            else
            {
                MessageBox.Show("Su entidad tiene lo maximo que puede obtener en puntos de defensa");
            }
            //try
            //{
            
                
            //}
            //catch(Exception e)
            //{
            //    MessageBox.Show(e.ToString());
            //}
            

        }

        public override string ToString()
        {
            return "Increases Defense Points";
        }
    }
}
