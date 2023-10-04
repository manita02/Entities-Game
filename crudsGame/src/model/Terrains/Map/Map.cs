using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Terrains.Map
{
    internal class Map
    {
        private List<Terrain> terrainsList;
        internal List<Terrain> TerrainsList { get => terrainsList; set => terrainsList = value; }
        public Map(List<Terrain> terrain)//al mapa le setea la lista de terrenos por parametro
        {
            TerrainsList = terrain;
        }
        public Map() { }
    }
}
