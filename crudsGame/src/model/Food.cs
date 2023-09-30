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
        public int id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Name = value;
                }
                else throw new NullReferenceException("The name cannot be empty!!");
            }
        }

        public int calories
        {
            get
            {
                return Calories;
            }
            set
            {
                if (value >= 10 && value <= 80)
                {
                    Calories = value;
                }
                else throw new ArgumentOutOfRangeException(nameof(value), "The valid range for calories is between 10 and 80.");
            }
        }


        public IDiet diet
        {
            get
            {
                return this.Diet;
            }
            set
            {
                if (value != null)
                {
                    Diet = value;
                    //MessageBox.Show("estoy");
                }
                else
                    //MessageBox.Show("cac");
                throw new InvalidOperationException("You have to select a diet");
            }
        }

        
        public bool Interact(Entity entity)
        {
            if (entity.currentEnergy != entity.maxEnergy)
            {
                entity.currentEnergy -= 10;
                entity.currentEnergy += this.Calories;
                MessageBox.Show("The creature " + entity.name + " ate " + Name + " and recovered +(" + Calories + ") energy");
                return true;
            }
            else
            {
                MessageBox.Show("The creature " + entity.name +" is full, he can't eat more!!");
                return true;
            }
        }
   
        public override string ToString()
        {
            return this.Name;
        }
    }
}
