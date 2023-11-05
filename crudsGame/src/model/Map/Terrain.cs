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
        private static int lastId = -1;//cheqqq
        private ITerrain terrainType;
        private List<Terrain> borderingTerrainsList = new List<Terrain>();

        private List<Entity> entitiesList = new List<Entity>();
        private List<Food> foodList = new List<Food>();
        private List<Item> itemList = new List<Item>();





        public int Id { get; private set; }
        internal ITerrain TerrainType { get => terrainType; set => terrainType = value; }
        public string TerrainTypeName { get => terrainType.ToString(); }
        internal List<Terrain> BorderingTerrainsList { get => borderingTerrainsList; set => borderingTerrainsList = value; }
        //internal List<IPositionable> PositionablesList { get => positionablesList; set => positionablesList = value; }

        internal List<Entity> EntitiesList { get => entitiesList; set => entitiesList = value; }
        internal List<Food> FoodsList { get => foodList; set => foodList = value; }
        internal List<Item> ItemsList { get => itemList; set => itemList = value; }




        //Ihabitat vendira a ser como ienvironmet q tengo yo es lo mismo
        //las comidas items y entidades deben implementar la iterfaz ipositionable y su metodo
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
            //PositionablesList = new List<IPositionable>();
            //aca lsita de posicionables no va debe haber una lista de entidades otra de comidas y tora de items

            EntitiesList = new List<Entity>();
            FoodsList = new List<Food>();
            itemList = new List<Item>();


        }
        public Terrain() { }
        public override string ToString()
        {
            return "id: " + Id + ", tipo: " + terrainType;
        }
    }
}
