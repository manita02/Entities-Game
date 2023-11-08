using crudsGame.Properties;
using crudsGame.src.interfaces;
using crudsGame.src.model.Kingdoms;
using crudsGame.src.views;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy.Positive
{
    internal class IncreasesAttackPoints : IStrategyTypeOfItem
    {
        Random random = new Random();
        public bool ApplyItem(Entity entity)
        {
            try
            {
                entity.currentEnergy -= 50;
                MessageBox.Show("The " + entity.name + " creature has used a item that increased its attack points!!", "ATENCIÓN", "Ok", Resources.check);
                entity.attackPoints += random.Next(10, 50);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", no podrá utilizar este item", "ALERTA", "Ok", Resources.warning);
                return false;
            }
        }

        public override string ToString()
        {
            return "Increases Attack Points";
        }
    }
}
