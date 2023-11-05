using crudsGame.Properties;
using crudsGame.src.interfaces;
using crudsGame.src.views;
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
        public void ApplyItem(Entity entity)
        {
            try
            {
                entity.currentEnergy -= random.Next(10, 50) - 5;
                MessageBox.Show("The " + entity.name + " creature used an item that made him lose energy (-" + entity.currentEnergy, "ATENCIÓN", "Ok", Resources.neg);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", "Ok", Resources.warning);
            }
            
        }

        public override string ToString()
        {
            return "Loses Energy";
        }
    }
}
