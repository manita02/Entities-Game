using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy.Negatives
{
    internal class LosesEnergy:IStrategyTypeOfItem
    {
        Random random = new Random();
        public bool ApplyItem(Entity entity)
        {
            try
            {
                //if (entity.currentEnergy != entity.maxEnergy)
                //{
                //MessageBox.Show("estoy: "+ entity.currentEnergy);
                entity.currentEnergy -= random.Next(10, 50) - 5;
                MessageBox.Show("The " + entity.name + " creature used an item that made him lose energy (-" + entity.currentEnergy);
                return true;
                //}
                //else
                //{
                //MessageBox.Show("no estoy");
                //MessageBox.Show("Su entidad tiene lo maximo que puede obtener en energia");
                //}
            }
            catch
            {
                return true;
            }
            
        }

        public override string ToString()
        {
            return "Loses Energy";
        }
    }
}
