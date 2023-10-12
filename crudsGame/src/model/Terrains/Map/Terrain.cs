using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Terrains.Map
{
    public class Terrain
    {
        private static int lastId = -1;//cheqqq
        private ITerrain terrainType;
        private List<Terrain> borderingTerrainsList = new List<Terrain>();
        //private List<IPositionable> positionablesList; me pa que noo
        private List<Entity>entitiesList=new List<Entity>();
        private List<Food> foodList = new List<Food>();
        private List<Item> itemList = new List<Item>();


        public int Id { get; private set; }
        internal ITerrain TerrainType { get => terrainType; set => terrainType = value; }
        public string TerrainTypeName { get => terrainType.ToString(); }
        internal List<Terrain> BorderingTerrainsList { get => borderingTerrainsList; set => borderingTerrainsList = value; }
        //internal List<IPositionable> PositionablesList { get => positionablesList; set => positionablesList = value; }

        internal List<Entity> EntitiesList { get => entitiesList; set => entitiesList = value; }

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
        }
        public Terrain() { }
        public override string ToString()
        {
            return "id: "+this.Id+ ", tipo: "+this.terrainType;
        }
    }
}
