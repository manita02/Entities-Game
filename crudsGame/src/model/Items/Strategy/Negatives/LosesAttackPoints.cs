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
    internal class LosesAttackPoints:IStrategyTypeOfItem
    {
        Random random = new Random();
        public bool ApplyItem(Entity entity)
        {
            //try
            //{
            //MessageBox.Show("ataque: " + entity.attackPoints);
            //if (entity.attackPoints != 0)
            //{
            try
            {
                entity.attackPoints -= random.Next(5, 15);
                entity.currentEnergy -= 10;
                new MessageBoxDarkMode("The " + entity.name + " creature used an item that made him lose attack points!!", "ATENCIÓN", "Ok", Resources.info, true);

                return true;

            }
            catch(Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                return true;
            }
                    
             //}
             //else
             //{
                //throw new Exception("La entidad " + entity.name + " ha perdido todos sus puntos de ataque!!");
               
                //MessageBox.Show("Su entidad perdió todos sus puntos de ataque!!");
                //return true;
             //}
            //}
            //catch
            //{
                //return true;
            //}
            
           
        }

        public override string ToString()
        {
            return "Loses Attack Points";
        }
    }
}
