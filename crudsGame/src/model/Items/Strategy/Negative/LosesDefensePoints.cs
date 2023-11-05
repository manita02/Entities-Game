using crudsGame.Properties;
using crudsGame.src.interfaces;
using crudsGame.src.views;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace crudsGame.src.model.Items.Strategy.Negatives
{
    internal class LosesDefensePoints:IStrategyTypeOfItem
    {
        Random random = new Random();
        public void ApplyItem(Entity entity)
        {
            try
            {
                entity.defensePoints -= random.Next(10, 50);
                entity.currentEnergy -= 50;
                MessageBox.Show("The " + entity.name + " creature used an item that made him lose defense points!!", "ATENCIÓN", "Ok", Resources.neg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", "Ok", Resources.warning);
            }
        }

        public override string ToString()
        {
            return "Loses Defense Points";
        }
    }
}
