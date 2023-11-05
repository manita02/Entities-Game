using crudsGame.src.interfaces;
using crudsGame.src.model.Foods.Diets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.factoryMethod
{
    public class DietCreator
    {
        public const int Carnivore = 1;
        public const int Herbivorous = 2;
        public const int Omnivorous = 3;
        public const int SolarEnergy = 4;

        public static IDiet CreateAdiet(int DietType)
        {
            switch (DietType)
            {
                case Carnivore:
                    return new Carnivore(); 
                case Herbivorous:
                    return new Herbivorous();
                case Omnivorous:
                    return new Omnivorous();
                case SolarEnergy:
                    return new SolarEnergy();
                default: return null;
            }
        }
    }
}
