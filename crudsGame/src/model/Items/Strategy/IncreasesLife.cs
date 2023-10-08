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
    internal class LifeeItem : IStrategyTypeOfItem
    {
        Random random = new Random();
        public void ApplyItem(Entity entity)
        {

            try
            {
                //if (entity.currentLife != entity.maxLife)
                //{
                        
                        entity.currentLife += random.Next(5, 15);
                        entity.currentEnergy -= 10;
                        new MessageBoxDarkMode("The " + entity.name + " creature has used a item that increased its life to " + entity.currentLife, "ATENCIÓN", "Ok", Resources.check, true);
                       
                        //return true;
                    

                //}
                //else
                //{
                    //MessageBox.Show("Su entidad tiene lo maximo que puede obtener en vida");
                    //return true;
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
            return "Increases Life";
        }
    }
}
