using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Diets
{
    internal class Herbivorous : IDiet
    {
        
        public bool CanEat(Entity entity, Food food)
        {
            if (entity.diet.ToString() == food.diet.ToString())
            {
                return true;
            }
            return false;
            
        }
        
        /*
        public bool CanEat(Food food)
        {
            return food.diet is Herbivorous;

        }
        */

        public override string ToString()
        {
            return "Herbivorous";
        }
    }
}
