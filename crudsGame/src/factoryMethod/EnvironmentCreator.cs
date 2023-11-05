using crudsGame.src.interfaces;
using crudsGame.src.model.Foods.Diets;
using crudsGame.src.model.Environments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.factoryMethod
{
    public class EnvironmentCreator
    {
        public const int Aereal = 1;
        public const int Aquatic = 2;
        public const int Terrestrial = 3;

        public static IEnvironment CreateAenvironment(int EnvironmentType)
        {
            switch (EnvironmentType)
            {
                case Aereal:
                    return new Aereal(); 
                case Aquatic:
                    return new Aquatic();
                case Terrestrial:
                    return new Terrestrial();
                default: return null;
            }
        }
    }
}
