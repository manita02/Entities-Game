﻿using crudsGame.Properties;
using crudsGame.src.interfaces;
using crudsGame.src.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Foods
{
    public class Food : IInteractuable
    {
        int Id;
        string Name;
        int Calories;
        IDiet Diet;

        public Food(int id, string namee, int Calories, IDiet diet)
        {
            Id = id;
            name = namee;
            calories = Calories;
            Diet = diet;
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
                else throw new Exception("The name cannot be empty!!");
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
                if (value > 0)
                {
                    Calories = value;
                }
                else throw new Exception("Las calorías deben ser mayores a cero");
            }
        }


        public IDiet diet
        {
            get
            {
                return Diet;
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


        public void Interact(Entity entity)
        {
            if (entity.currentEnergy != entity.maxEnergy)
            {
                entity.currentEnergy -= 10;
                entity.currentEnergy += Calories;
                new MessageBoxDarkMode("The creature " + entity.name + " ate " + Name + " and recovered + (" + Calories + ") energy", "ATENCIÓN", "Ok", Resources.check, true);

                //return true;
            }
            else
            {
                new MessageBoxDarkMode("The creature " + entity.name + " is full, he can't eat more!!", "ALERTA", "Ok", Resources.warning, true);
                //return true;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}