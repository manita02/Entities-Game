using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy
{
    internal class EnergyyItem : IStrategyTypeOfItem
    {
        Random random = new Random();
        public bool ApplyItem(Entity entity)
        {
            try
            {
                if (entity.currentEnergy != entity.maxEnergy)
                {
                    //MessageBox.Show("estoy: "+ entity.currentEnergy);
                    entity.currentEnergy += random.Next(10, 50) - 10;
                    MessageBox.Show("The " + entity.name + " creature has used a item that increased its energy to " + entity.currentEnergy);
                    return true;
                }
                else
                {
                    //MessageBox.Show("no estoy");
                    MessageBox.Show("Su entidad tiene lo maximo que puede obtener en energia");
                    return true;
                }
            }
            catch
            {
                return true;
            }

            

            
            
            

            
            /*
            try {
                MessageBox.Show("estoy por hacer el incremento");
                entity.currentEnergy += random.Next(10, 40);
                MessageBox.Show("ya lo hice: "+entity.currentEnergy);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            */
        }

        public override string ToString()
        {
            return "Increases Energy";
        }
    }
}
