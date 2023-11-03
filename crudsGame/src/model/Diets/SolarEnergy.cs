using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Diets
{
    internal class SolarEnergy : IDiet
    {
        /*
        public bool CanEat(Entity entity, Food food)
        {
            //MessageBox.Show("dieta entidad: " + entity.diet);
            //MessageBox.Show("dieta comida: " + food.diet);

            if (entity.diet.ToString() == food.diet.ToString())
            {
                //MessageBox.Show("entre");
                return true;
            }
            
            return false;
        }
        */

        public bool CanEat(Food food)
        {
            //MessageBox.Show("dieta entidad: " + entity.diet.ToString());
            //MessageBox.Show("comida dieta: " + food.diet.ToString());

            return food.diet is SolarEnergy;

        }

        public override string ToString()
        {
            return "Solar Energy";
        }

        /* lo metio en una controladora a este
        public void Eat(Entity entity, Food food)
        {
            if (food.Diet.Contains(entity.Diet))
            {
                entity.CurrentEnergy += food.EnergyValue;
            }
            else throw new Exception($"no es compatible con la dieta. {food.Name} {food.Diet} != {entity.Name} {entity.Diet}");
        }
        */
    }
}
