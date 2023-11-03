using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Diets
{
    internal class Omnivorous : IDiet
    {
        /*
        public bool CanEat(Entity entity, Food food)
        {
            //MessageBox.Show("dieta entidad: " + entity.diet.ToString());
            //MessageBox.Show("comida dieta: " + food.diet.ToString());

            if (entity.diet.ToString() == "Omnivorous" && ((food.diet.ToString() == "Carnivore") || (food.diet.ToString() == "Herbivorous")))
            {
                return true;
            }
            return false;
            
        }
        */
        
        
        public bool CanEat(Food food)
        {
            //MessageBox.Show("dieta entidad: " + entity.diet.ToString());
            //MessageBox.Show("comida dieta: " + food.diet.ToString());

            return food.diet is Carnivore || food.diet is Herbivorous;
          
        }
        

        public override string ToString()
        {
            return "Omnivorous";
        }
    }
}
