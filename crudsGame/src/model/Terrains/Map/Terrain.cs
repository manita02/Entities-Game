using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Terrains.Map
{
    internal class Terrain
    {
        private static int lastId = 0;
        private ITerrain terrainType;
        private List<Terrain> borderingTerrainsList = new List<Terrain>();
        //private List<IPositionable> positionables;

        
        public int Id { get; private set; }
        internal ITerrain TerrainType { get => terrainType; set => terrainType = value; }
        public string TerrainTypeName { get => terrainType.ToString(); }
        internal List<Terrain> BorderingTerrainsList { get => borderingTerrainsList; set => borderingTerrainsList = value; }
        //internal List<IPositionable> Positionables { get => positionables; set => positionables = value; }

        /*
        public string BorderingLandsIds
        {
            get
            {
                string borderingLandsIds = "";
                foreach (var b in BorderingLands)
                {
                    borderingLandsIds = string.Join(", ", BorderingLands);
                }
                return borderingLandsIds;
            }
        }

        */
        

        public Terrain(ITerrain terrainType)
        {
            lastId++;
            Id = lastId;
            TerrainType = terrainType;
        }
        public Terrain() { }
        public override string ToString()
        {
            return "id: "+this.Id+ ", tipo: "+this.terrainType;
        }
    }
}
