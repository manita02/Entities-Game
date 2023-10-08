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
    internal class IncreasesDefensePoints : IStrategyTypeOfItem
    {
        Random random = new Random();
        public void ApplyItem(Entity entity)
        {
            try
            {
                //if (entity.defensePoints != 80)
                //{
                    entity.currentEnergy -= 10;
                    new MessageBoxDarkMode("The " + entity.name + " creature has used a item that increased its defense points!!", "ATENCIÓN", "Ok", Resources.check, true);
                    
                    entity.defensePoints += random.Next(5, 15);
                    //return true;
                //}
                //else
                //{
                    //MessageBox.Show("Su entidad tiene lo maximo que puede obtener en puntos de defensa");
                    //return true;
                //}
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message + ", no podrá utilizar este item", "ALERTA", "Ok", Resources.warning, true);
                //return true;
            }




        }

        public override string ToString()
        {
            return "Increases Defense Points";
        }
    }
}
