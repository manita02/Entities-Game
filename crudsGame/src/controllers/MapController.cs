using crudsGame.src.interfaces;
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
        private TerrainController terrainController = TerrainController.GetInstance();
        private static MapController instance;
        private readonly Map map = new Map();
        //private readonly List<IPositionable> positionables = new List<IPositionable>();
        //private readonly List<Land> landsInMap = new List<Land>();
        private MapController() { }
        public static MapController GetInstance()
        {
            if (instance == null)
            {
                instance = new MapController();
            }
            return instance;
        }

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

        public void GenerateMap()
        {
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                List<ITerrain> terrainTypes = TerrainsTypesList();
                ITerrain randomTerrain = terrainTypes[random.Next(terrainTypes.Count)];//ELIJE UN TIPO DE TIERRA ALEATORIA
                terrainController.AddTerrain(randomTerrain); //agrega el terreno y le pasa su tipo 
                //TODO: resolver de si trabajar con la controladora de lands o mapas.
                //map.Lands.Add()
            }
            //map.Lands = landController.getLands();
            //map.Lands = land
            terrainController.setBorderingLands(); //una vez q salio de for setea de forma general a todos los terrenos creados sus limitrofes
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
    }
}
