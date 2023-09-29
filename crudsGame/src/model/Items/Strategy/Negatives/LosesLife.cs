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
        public void ApplyItem(Entity entity)
        {
            //if (entity.currentLife != 0)
            //{
                entity.currentEnergy -= 10;
                entity.currentLife -= random.Next(5, 15);
                MessageBox.Show("The " + entity.name + " creature used an item that made him lose life (-" + entity.currentLife);
            //}
            //else
            //{
                //MessageBox.Show("Su entidad tiene lo maximo que puede obtener en vida");
            //}


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
