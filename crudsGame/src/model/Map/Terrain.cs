using crudsGame.src.interfaces;
using crudsGame.src.model.Foods;
using crudsGame.src.model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Map
{
    public class Terrain
    {
        private static int lastId = -1;
        private ITerrain terrainType;
        private List<Terrain> borderingTerrainsList = new List<Terrain>();
        private List<Entity> entitiesList = new List<Entity>();
        private List<Food> foodList = new List<Food>();
        private List<Item> itemList = new List<Item>();

        #region Properties
        public int Id { get; private set; }
        internal ITerrain TerrainType { get => terrainType; set => terrainType = value; }
        internal List<Terrain> BorderingTerrainsList { get => borderingTerrainsList; set => borderingTerrainsList = value; }
        internal List<Entity> EntitiesList { get => entitiesList; set => entitiesList = value; }
        internal List<Food> FoodsList { get => foodList; set => foodList = value; }
        internal List<Item> ItemsList { get => itemList; set => itemList = value; }
        #endregion
        public Terrain(ITerrain terrainType)
        {
            lastId++;
            Id = lastId;
            TerrainType = terrainType;
            EntitiesList = new List<Entity>();
            FoodsList = new List<Food>();
            itemList = new List<Item>();
        }
        
        public override string ToString()
        {
            return "id: " + Id + ", tipo: " + terrainType;
        }
    }
}
