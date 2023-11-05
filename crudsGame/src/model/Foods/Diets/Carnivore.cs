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
        public bool CanEat(Food food)
        {
            return food.diet is Carnivore; 

        }

        public override string ToString()
        {
            return "Carnivore";
        }
    }
}
