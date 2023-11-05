using crudsGame.src.interfaces;
using crudsGame.src.model.Kingdoms;
using crudsGame.src.model.Map.Terrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.factoryMethod
{
    public class TerrainCreator
    {
        public const int Land = 1;
        public const int Water = 2;
        public static ITerrain CreateAterrain(int TerrainsType)
        {
            switch (TerrainsType)
            {
                case Land:
                    return new Land();
                case Water:
                    return new Water();
                default: return null;
            }
        }
    }
}
