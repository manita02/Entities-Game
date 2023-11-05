using crudsGame.Properties;
using crudsGame.src.interfaces;
using crudsGame.src.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy.Positive
{
    internal class IncreasesDefensePoints : IStrategyTypeOfItem
    {
        Random random = new Random();
        public void ApplyItem(Entity entity)
        {
            try
            {
                entity.currentEnergy -= 50;
                MessageBox.Show("The " + entity.name + " creature has used a item that increased its defense points!!", "ATENCIÓN", "Ok", Resources.check);
                entity.defensePoints += random.Next(10, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", no podrá utilizar este item", "ALERTA", "Ok", Resources.warning);
            }
        }

        public override string ToString()
        {
            return "Increases Defense Points";
        }
    }
}
