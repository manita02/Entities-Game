using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace crudsGame.src.model.Map
{
    internal class Map
    {
        private List<Terrain> terrainsList;
        public int Id { get; private set; }
        internal List<Terrain> TerrainsList { get => terrainsList; set => terrainsList = value; }
        
        public Map()
        {
            Id = 1;
            TerrainsList = new List<Terrain>();
        }

        public override string ToString()
        {
            return "Map_" + Id;
        }
    }
}
