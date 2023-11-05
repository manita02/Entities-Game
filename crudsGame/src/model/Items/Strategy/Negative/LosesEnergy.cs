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
                //if (entity.currentEnergy != entity.maxEnergy)
                //{
                //MessageBox.Show("estoy: "+ entity.currentEnergy);
                entity.currentEnergy -= random.Next(10, 50) - 5;
                new MessageBoxDarkMode("The " + entity.name + " creature used an item that made him lose energy (-" + entity.currentEnergy, "ATENCIÓN", "Ok", Resources.neg, true);
                
                //return true;
                //}
                //else
                //{
                //MessageBox.Show("no estoy");
                //MessageBox.Show("Su entidad tiene lo maximo que puede obtener en energia");
                //}
            }
            catch(Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                //return true;
            }
            
        }

        public override string ToString()
        {
            return "Loses Energy";
        }
    }
}
