using crudsGame.src.interfaces;
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
        public bool ApplyItem(Entity entity)
        {

            try
            {
                if (entity.currentLife != entity.maxLife)
                {
                       entity.currentEnergy -= 10;
                        entity.currentLife += random.Next(5, 15);
                        MessageBox.Show("The " + entity.name + " creature has used a item that increased its life to " + entity.currentLife);
                        return true;
                    

                }
                else
                {
                    MessageBox.Show("Su entidad tiene lo maximo que puede obtener en vida");
                    return true;
                }
            }
            catch
            {
                return true;
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
