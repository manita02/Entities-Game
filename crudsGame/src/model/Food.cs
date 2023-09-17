using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model
{
    public class Food : IInteractuable
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

        public IDiet diet
        {
            get
            {
                return this.Diet;
            }
            set
            {
                Diet = value;
            }

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

        
        public void Interact(Entity entity)
        {
            entity.currentEnergy += this.Calories;
 
        }
   
        public override string ToString()
        {
            return this.Name;
        }
    }
}
