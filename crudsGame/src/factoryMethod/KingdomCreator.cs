using crudsGame.src.interfaces;
using crudsGame.src.model.Kingdoms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.factoryMethod
{
    public class KingdomCreator
    {
        public const int Alien = 1;
        public const int Animalia = 2;
        public const int Machine = 3;
        public const int Plantae = 4;

        public static IKingdom CreateAkingdom(int KingdomsType)
        {
            switch (KingdomsType)
            {
                case Alien:
                    return new Alien(); 
                case Animalia:
                    return new Animalia();
                case Machine:
                    return new Machine();
                case Plantae:
                    return new Plantae();
                default: return null;
            }
        }
    }
}
