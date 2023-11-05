using crudsGame.src.interfaces;
using crudsGame.src.model.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Foods.Diets
{
    internal class Carnivore : IDiet
    {
        /*
        public bool CanEat(Entity entity, Food food)
        {
            if (entity.diet.ToString() == food.diet.ToString())
            {
                return true;
            }
            return false;
            
        }
        */


        public bool CanEat(Food food)
        {
            return food.diet is Carnivore; //devuelve true

        }



        public override string ToString()
        {
            return "Carnivore";
        }
    }
}
