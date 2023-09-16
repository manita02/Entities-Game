using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crudsGame.src.factoryMethod
{
    public class EntityCreator//esta al dopee esto
    {
        public static IEntity CreateAnEntity(string kingdomName, int id, IKingdom kingdom, string name, IDiet diet, IEnvironment environment, int maxEnergy, int currentEnergy, int maxLife, int currentLife, int attack, int defense, int range)
        {
            switch (kingdomName)
            {
                case "Alien":
                    //return new Alien(); 
                case "Animal":
                    //return new Animal();
                case "Fungus":
                    //return new Fungus();
                case "Plant":
                    //return new Plant();
                case "Robot":
                    //return new Robot();
                default: return null; 
            }
        }
        
    }
}
