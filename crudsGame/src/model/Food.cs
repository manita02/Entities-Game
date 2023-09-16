using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model
{
    internal class Food : IFood /*, IInteractuable*/
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

        public int GetCalories()
        {
            throw new NotImplementedException();
        }

        public IDiet GetDiet()
        {
            return this.Diet;
        }

        public void Interact(IEntity entity)
        {
            /*
            if (Diet.CanEat(entity,) == true)
            {

            }
            */
        }
    }
}
