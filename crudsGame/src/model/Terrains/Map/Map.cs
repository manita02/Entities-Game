using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace crudsGame.src.model.Terrains.Map
{
    internal class Map
    {
        private static int lastId = 0;
        private List<Terrain> terrainsList;
        public int Id { get; private set; }
        internal List<Terrain> TerrainsList { get => terrainsList; set => terrainsList = value; }
        public Map(List<Terrain> terrain)//al mapa le setea la lista de terrenos por parametro
        {
            lastId++;
            Id = lastId;
            TerrainsList = terrain;
        }
        public Map()
        {
            lastId++;
            Id = lastId;
            TerrainsList = new List<Terrain>();
        }

        public override string ToString()
        {
            return "Map_" + Id;
        }
    }
}
