using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Diets
{
    internal class Carnivore : IDiet
    {
        public bool CanEat(Entity entity, Food food)
        {
            if (entity.diet.ToString() == food.diet.ToString())
            {
                return true;
            }
            return false;
            
        }

        public override string ToString()
        {
            return "Carnivore";
        }
    }
}
