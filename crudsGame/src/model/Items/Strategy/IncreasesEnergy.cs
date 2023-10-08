using crudsGame.Properties;
using crudsGame.src.interfaces;
using crudsGame.src.views;
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
        public void ApplyItem(Entity entity)
        {
            try
            {
                //if (entity.currentEnergy != entity.maxEnergy)
                //{
                    //MessageBox.Show("estoy: "+ entity.currentEnergy);
                    entity.currentEnergy += random.Next(10, 50) - 10;
                    new MessageBoxDarkMode("The " + entity.name + " creature has used a item that increased its energy to " + entity.currentEnergy, "ATENCIÓN", "Ok", Resources.check, true);
                    
                    //return true;
                //}
                //else
                //{
                    //MessageBox.Show("no estoy");
                    //MessageBox.Show("Su entidad tiene lo maximo que puede obtener en energia");
                    //return true;
                //}
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                //return true;
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
