using crudsGame.src.interfaces;
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
        public bool ApplyItem(Entity entity)
        {
            try
            {
                MessageBox.Show(entity.currentLife.ToString());
                if (entity.currentLife != 0)
                {
                    entity.currentEnergy -= 10;
                    entity.currentLife -= random.Next(5, 30);
                    MessageBox.Show("The " + entity.name + " creature used an item that made him lose life (-" + entity.currentLife);
                    return true;
                }
                else
                {
                    MessageBox.Show("Su entidad ha muerto");
                    return false;
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
            return "Loses Life";
        }
    }
}
