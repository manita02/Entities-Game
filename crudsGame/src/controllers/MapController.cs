using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Environments;
using crudsGame.src.model.Terrains;
using crudsGame.src.model.Terrains.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.controllers
{
    internal class MapController
    {
        //private TerrainController terrainController = TerrainController.GetInstance();
        private static MapController instance;
        private readonly List<Map> maps = new List<Map>();
        private readonly List<Land> Lands = new List<Land>();
        private readonly List<IPositionable> positionables = new List<IPositionable>();
        
        
        private MapController() { }
        public static MapController GetInstance()
        {
            if (instance == null)
            {
                instance = new MapController();
            }
            return instance;
        }

       

        public void AddTerrain(ITerrain terrainType, Map map)
        {
            
                Terrain TerrainToAdd = new Terrain(terrainType);
                //MessageBox.Show("terreno a añadir: " + TerrainToAdd.ToString());
            
                map.TerrainsList.Add(TerrainToAdd);

            
            
            
        }

        public void AddBorderingTerrain(Terrain terrainToModify, Terrain BorderingTerrainToAdd)
        {
            terrainToModify.BorderingTerrainsList.Add(BorderingTerrainToAdd);
        }

        public List<Terrain> GetTerrains(Map map)
        {
            /*
            int i = 0;
            foreach (var hexagon in map.TerrainsList)
            {
                MessageBox.Show("nombre: " + hexagon.ToString());
                i++;
            }
            */
            return map.TerrainsList;
        }

        public List<Map> GetMaps()
        {
            return maps;
        }

        public List<Terrain> GetBorderingTerrains(Terrain terrain)
        {
            return terrain.BorderingTerrainsList;
        }

        /*
        public List<IPositionable> getPositionbalesInAllLands()
        {
            List<IPositionable> allPositionables = new List<IPositionable>();
            foreach (Land land in Lands)
            {
                allPositionables.AddRange(land.Positionables);
            }
            return allPositionables;
        }
        */

        public List<ITerrain> TerrainsTypesList()
        {
            
            List<ITerrain> terrainTypesList = new List<ITerrain>();
            terrainTypesList.Add(new Land());
            terrainTypesList.Add(new Water());


            return terrainTypesList;
            

            /*
            List<ITerrain> terrainTypesList = new List<ITerrain>();
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ITerrain))))
            {
                terrainTypesList.Add((ITerrain)Activator.CreateInstance(type));
            }
            return terrainTypesList;
            */
            
        }

        /*anterioooooooooooor con controladora de terrenossss
        public void GenerateMap()
        {
            var random = new Random();
            for (int i = 0; i < 4; i++)
            {
                List<ITerrain> terrainTypes = TerrainsTypesList();
                ITerrain randomTerrain = terrainTypes[random.Next(terrainTypes.Count)];
                terrainController.AddTerrain(randomTerrain);
                //TODO: resolver de si trabajar con la controladora de lands o mapas.
                //map.Lands.Add()
            }
            //map.Lands = landController.getLands();
            //map.Lands = land
            terrainController.setBorderingLands(); //una vez q salio de for setea de forma general a todos los terrenos creados sus limitrofes
        }
        */

        public void GenerateMap()
        {
            Map map = new Map();
            var random = new Random();
            for (int i = 0; i < 19; i++)
            {
                List<ITerrain> terrainTypes = TerrainsTypesList();
                //MessageBox.Show("cantidad de tipos de terrenos: " + terrainTypes.Count);
                ITerrain randomTerrain = terrainTypes[random.Next(terrainTypes.Count)];
                //MessageBox.Show("index seleccioado: " + randomTerrain);
                AddTerrain(randomTerrain, map);
            }
            maps.Add(map);
            setBorderingTerrains(map); //una vez q salio de for setea de forma general a todos los terrenos creados sus limitrofes
            //SetPositionsOfPositionableObjects(map); 
        }
        /*
        public Map GetMap()
        {
            return map;
        }*/


        /*
        public void SetPositions()
        {
            Random random = new Random();
            foreach (IPositionable positionable in positionables)
            {
                int randomLand = random.Next(0, terrainController.getLands().Count);
                positionable.Position(terrainController.getLands()[randomLand]);
            }
        }
        */

        public void SetPosition(IPositionable positionable)
        {

        }

        public void setBorderingTerrains(Map map)
        {
            map.TerrainsList[0].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[1], map.TerrainsList[5], map.TerrainsList[6] };
            map.TerrainsList[1].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[0], map.TerrainsList[6], map.TerrainsList[7], map.TerrainsList[2] };
            map.TerrainsList[2].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[1], map.TerrainsList[7], map.TerrainsList [3] };
            map.TerrainsList[3].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[2], map.TerrainsList[7], map.TerrainsList[8], map.TerrainsList[4] };
            map.TerrainsList[4].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[3], map.TerrainsList[8], map.TerrainsList[9] };
            map.TerrainsList[5].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[0], map.TerrainsList[6], map.TerrainsList[11], map.TerrainsList[10] };
            map.TerrainsList[6].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[0], map.TerrainsList[1], map.TerrainsList[7], map.TerrainsList[12], map.TerrainsList[11], map.TerrainsList[5] };
            map.TerrainsList[7].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[1], map.TerrainsList[2], map.TerrainsList[3], map.TerrainsList[8], map.TerrainsList[12], map.TerrainsList[6] };
            map.TerrainsList[8].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[7], map.TerrainsList[3], map.TerrainsList[4], map.TerrainsList[9], map.TerrainsList[13], map.TerrainsList[12] };
            map.TerrainsList[9].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[4], map.TerrainsList[8], map.TerrainsList[13], map.TerrainsList[14] };
            map.TerrainsList[10].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[5], map.TerrainsList[11], map.TerrainsList[15] };
            map.TerrainsList[11].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[10], map.TerrainsList[5], map.TerrainsList[6], map.TerrainsList[12], map.TerrainsList[16], map.TerrainsList[15] };
            map.TerrainsList[12].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[6], map.TerrainsList[7], map.TerrainsList[8], map.TerrainsList[11], map.TerrainsList[16], map.TerrainsList[13] };
            map.TerrainsList[13].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[12], map.TerrainsList[8], map.TerrainsList[9], map.TerrainsList[14], map.TerrainsList[17], map.TerrainsList[16] };
            map.TerrainsList[14].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[9], map.TerrainsList[13], map.TerrainsList[17] };
            map.TerrainsList[15].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[10], map.TerrainsList[11], map.TerrainsList[16], map.TerrainsList[18] };
            map.TerrainsList[16].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[15], map.TerrainsList[11], map.TerrainsList[12], map.TerrainsList[13], map.TerrainsList[17], map.TerrainsList[18] };
            map.TerrainsList[17].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[14], map.TerrainsList[13], map.TerrainsList[16], map.TerrainsList[18] };
            map.TerrainsList[18].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[15], map.TerrainsList[16], map.TerrainsList[17] };
        }


        /* ver estooooooooooo posicionaaaaaaaabless
        public void SetPositionsOfPositionableObjects(Map map)
        {
            Random random = new Random();
            foreach (IPositionable positionable in PositionableObjectRegistry.GetAllPositionableObjects())
            {
                int randomLand = random.Next(0, getLands(map).Count);
                //TODO: resolver como colocar en el mapa las entidades según su habitat.
                //if(getLands(map)[randomLand].TerrainType.getHabitatsSupported().Contains())
                getLands(map)[randomLand].Positionables.Add(positionable);
                //positionable.Position(getLands(map)[randomLand]);
            }
        }
        public List<IPositionable> GetPositionablesInLand(Land land)
        {
            return land.Positionables;
        }

        //Generics para traer IPositionables según la clase.
        public List<T> GetPositionablesInLand<T>(Land land) where T : IPositionable
        {
            return land.Positionables.OfType<T>().ToList();
        }


        public void MoveMovible2(Land landOrigin, Land landDestiny, Entity entity)
        {
            List<IPositionable> MoviblesToRemove = new List<IPositionable>();

            foreach (IPositionable p in landOrigin.Positionables)
            {
                if (p.Equals(entity))
                {
                    MoviblesToRemove.Add(p);
                    landDestiny.Positionables.Add(p);
                    break;
                }
            }

            foreach (IPositionable p in MoviblesToRemove)
            {
                landOrigin.Positionables.Remove(p);
            }
        }

        public void MoveMovible(Land landOrigin, Land landDestiny, Entity entity)
        {
            foreach (var habitat in entity.HabitatList)
            {
                if (landDestiny.TerrainType.getHabitatsSupported().Contains(habitat))
                {
                    landDestiny.Positionables.Add(entity);
                    landOrigin.Positionables.Remove(entity);
                }
                else throw new Exception($"{entity} ({entity.HabitatName}) no es compatible con el tipo de terreno {landDestiny}");
            }


        }
        */
    }
}
