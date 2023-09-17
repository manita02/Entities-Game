using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model
{
    internal class Food : IInteractuable
    {
        int Id;
        string Name;
        int Calories;
        IDiet Diet;

        public Food(int id, string name, int Calories, IDiet diet)
        {
            Id = id;
            Name = name;
            this.Calories = Calories;
            this.Diet = diet;
        }

        /*
        public int GetCalories()
        {
            return this.Calories;
        }

        public IDiet GetDiet()
        {
            return this.Diet;
        }
        */

        /*
        public void Interact(IEntity entity, int value)
        {
            entity.CurrentEnergy += value;

            /* esto va en la clase entidad
            if (Diet.CanEat(entity,this.Diet) == true)
            {

            }
            
            
        }
    */

        public void Interact(Entity entity)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
