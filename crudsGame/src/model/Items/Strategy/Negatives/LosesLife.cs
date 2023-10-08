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
    internal class LosesLife:IStrategyTypeOfItem
    {
        Random random = new Random();
        public void ApplyItem(Entity entity)
        {
            try
            {
                //MessageBox.Show(entity.currentLife.ToString());
                //if (entity.currentLife != 0)
                //{
                    
                    entity.currentLife -= random.Next(5, 30);
                    entity.currentEnergy -= 10;
                    new MessageBoxDarkMode("The " + entity.name + " creature used an item that made him lose life (-" + entity.currentLife, "ATENCIÓN", "Ok", Resources.neg, true);
                
                    //return true;
                //}
                //else
                //{
                    //MessageBox.Show("Su entidad ha muerto");
                    //return false;
                //}
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                //return true;
            }
            


            //}
            //catch(Exception e)
            //{
            //    MessageBox.Show(e.ToString());
            //}

        }


        public override string ToString()
        {
            return "Loses Life";
        }
    }
}
