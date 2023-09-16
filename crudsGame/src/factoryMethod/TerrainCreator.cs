using crudsGame.src.interfaces;
using crudsGame.src.model.Kingdoms;
using crudsGame.src.model.Terrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.factoryMethod
{
    public class TerrainCreator
    {
        public static ITerrain CreateAterrain(string seleccionDelCombo)
        {
            switch (seleccionDelCombo)
            {
                case "Air":
                    return new Air(); //estos metodos serian para cargar los combo
                case "Land":
                    return new Land();
                case "Water":
                    return new Water();
                default: return null;
            }
        }
    }
}
