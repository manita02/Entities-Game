using crudsGame.Properties;
using crudsGame.src.controllers;
using crudsGame.src.interfaces;
using crudsGame.src.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy.Positive
{
    internal class LifeeItem : IStrategyTypeOfItem
    {
        Random random = new Random();
        public bool ApplyItem(Entity entity)
        {
            try
            {
                entity.currentLife += random.Next(10, 50);
                entity.currentEnergy -= 50;
                GeneralController.PlaySoundEffect(Resources.posicion);
                MessageBox.Show("The " + entity.name + " creature has used a item that increased its life to " + entity.currentLife, "ATENCIÓN", "Ok", Resources.check);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", "Ok", Resources.warning);
                return false;
            }
        }

        public override string ToString()
        {
            return "Increases Life";
        }
    }
}
