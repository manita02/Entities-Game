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
        public bool CanEat(IEntity entity, IFood food)
        {
            if (food.GetDiet() == entity.Diet)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Herbivorous";
        }
    }
}
