﻿using crudsGame.Properties;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Environments;
using crudsGame.src.model.Foods;
using crudsGame.src.model.Items;
using crudsGame.src.model.Map;
using crudsGame.src.model.Map.Terrains;
using crudsGame.src.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Message = crudsGame.src.model.Message;

namespace crudsGame.src.controllers
{
    internal class MapController
    {
        private EntityController entityCtn = EntityController.getInstance();
        private FoodController foodCtn = FoodController.getInstance();
        private ItemController itemCtn = ItemController.getInstance();


        //private TerrainController terrainController = TerrainController.GetInstance();
        private static MapController instance;
        private readonly Map map = new Map();
        //private readonly List<Map> maps = new List<Map>();
        //private readonly List<Land> Lands = new List<Land>();
        private readonly List<IPositionable> positionables = new List<IPositionable>();
        int problema = 0;





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
            //MessageBox.Show("cantidad en lista de terrenos " + map.TerrainsList.Count);
            return map.TerrainsList;
        }

        public Map GetMap()
        {
            return map;
        }

        public List<Terrain> GetBorderingTerrains(Terrain terrain)
        {
            return terrain.BorderingTerrainsList;
        }


        public List<ITerrain> TerrainsTypesList()
        {

            List<ITerrain> terrainTypesList = new List<ITerrain>();
            terrainTypesList.Add(new Land());
            terrainTypesList.Add(new Water());


            return terrainTypesList;

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

        public bool GenerateMap()
        {
            //try
            //{
                if (chequearSiHayCuarentaEntidadesComidasItems() == true)
                {
                    //Map map = new Map();
                    var random = new Random();
                    for (int i = 0; i < 19; i++)
                    {
                        List<ITerrain> terrainTypes = TerrainsTypesList();
                        //MessageBox.Show("cantidad de tipos de terrenos: " + terrainTypes.Count);
                        ITerrain randomTerrain = terrainTypes[random.Next(terrainTypes.Count)];
                        //MessageBox.Show("index seleccioado: " + randomTerrain);
                        AddTerrain(randomTerrain, map);

                        /*
                        if (i % 4 == 0)
                        {
                            AddTerrain(new Water(), map);
                        }
                        else
                        {
                            if (i % 3 == 0)
                            {
                                AddTerrain(new Water(), map);
                            }
                            else
                            {
                                if (i % 2 == 0)
                                {
                                    AddTerrain(new Land(), map);
                                }
                                else
                                {
                                    AddTerrain(new Land(), map);
                                }

                            }

                        }
                        */



                    }
                    //MessageBox.Show("cantidad en lista de terrenos " + map.TerrainsList.Count);
                    //MessageBox.Show("cantidad en lista de terrenos desde el get " + GetMap().TerrainsList.Count);
                    
                    //maps.Add(map);
                    setBorderingTerrains(map); //una vez q salio de for setea de forma general a todos los terrenos creados sus limitrofes
                    setEntidadesEnMapa(map);
                    setComidasEnMapa(map);
                    setItemsEnMapa(map);

                    return true;
                }
                return false;
            //}
            //catch (Exception e)
            //{
                //new MessageBoxDarkMode(e.Message, "Aviso", "Ok", Resources.warning, true);
            //}
            //return false;
            
            


        }

        public bool chequearSiHayCuarentaEntidadesComidasItems()
        {
            if ((entityCtn.GetEntitiesList().Count < 40) || (foodCtn.GetFoodList().Count < 40) || (itemCtn.GetItemList().Count < 40))
            {
                throw new Exception("Para poder generar el mapa deben existir 40 entidades, 40 comidas y 40 items. Por favor verifique en los CRUDs que haya creado esta cantidad.");
                
            }
            return true;   
        }

        public bool buscarsilaentidadyaseagregoalmapaenalgunterreno(Entity entidadAbuscar, Map map)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                if (terr.EntitiesList.Contains(entidadAbuscar))
                {
                    //MessageBox.Show("la entidad: " + entidadAbuscar.name + " ya ha sido agregada en otro terreno");
                    return true;
                }

            }
            //MessageBox.Show("la entidad: " + entidadAbuscar.name + " ESTA DISPONIBLE PARA SER AGREGADA!!");
            return false;
        }



        private Entity obtenerunaentidadrandomquecoindaconelterrenodondeseubicara(Terrain terrain, List<Entity> newList, List<int> availableIndexes)
        {
            int x = 0;

            Random random = new Random();
            //MessageBox.Show("ambiente por parametro: " + terrain.TerrainType.ToString());

            //MessageBox.Show("valor de availbale indices: " + availableIndexes.Count);

            while (x != 1)
            {
                //problema = 0;
                x = 0;
                //se elije un indice random de la lista de indices disponibles para agregar de la lista de entidades
                int indexrandmom = random.Next(availableIndexes.Count);
                //MessageBox.Show("index random: " + indexrandmom+ " _cantidad en la newList: "+newList.Count+" cantidad de indices disponibles: "+availableIndexes.Count);

                //aca de la lista de entidades que seria newList se le asigna entre corchetes el index anterior para obtener una entidad random
                Entity randomEntityOne = newList[indexrandmom];
                //MessageBox.Show("trabajando con: " + randomEntityOne.name);

                switch (terrain.TerrainType)
                {
                    case Water: //si el terreno es agua
                        foreach (IEnvironment env in randomEntityOne.environmentList)
                        {
                            if (problema != 50)
                            {
                                //MessageBox.Show("ambiente necesito que sea aquatico: " + env.ToString());

                                if (env is Aquatic || env is Aereal) //si en la lista de ambientes de la entidad random obtenida anteriormente tiene a acuatico o aereo
                                {
                                    x++;//corta el ciclo x = 1
                                        //MessageBox.Show("La entidad" + randomEntityOne.name + "es aquatico_ valor de x: " + x);
                                        //MessageBox.Show("llegandooo");
                                    return randomEntityOne; //retorna la entidad para que pueda ser agregada
                                }

                                problema++;
                                //MessageBox.Show("valor del problema en water: " + problema);
                            }
                            else
                            {
                                throw new Exception("Algunas de las entidades creadas no podrán colocarse sobre los terrenos aleatorios generados debido a que en su propia lista de ambientes, no coinden con los terrenos que se encontraban libres para ocupar... problema = " + problema);
                                //MessageBox.Show("ocurrio un error debera de volver a generar el mapa.. problema = " + problema);
                            }
                        }
                        break;
                    case Land:
                        foreach (IEnvironment env in randomEntityOne.environmentList)
                        {
                            if (problema != 50)
                            {
                                //MessageBox.Show("ambiente necesito que sea terrestre: " + env.ToString());
                                if (env is Terrestrial || env is Aereal)
                                {

                                    x++;
                                    //MessageBox.Show("La entidad" + randomEntityOne.name + "es terrestre valor de x: " + x);
                                    //MessageBox.Show("llegandooo");
                                    return randomEntityOne;
                                }

                                problema++;
                                //MessageBox.Show("valor del problema en tierra: " + problema);
                            }
                            else
                            {
                                throw new Exception("Algunas de las entidades creadas no podrán colocarse sobre los terrenos aleatorios generados debido a que en su propia lista de ambientes, no coinden con los terrenos que se encontraban libres para ocupar... problema = " + problema);
                                //MessageBox.Show("ocurrio un error debera de volver a generar el mapa.. problema = " + problema);
                            }
                        }
                        break;

                }

                /*
                if (terrain.TerrainType is Water)
                {
                    foreach (IEnvironment env in randomEntityOne.environmentList)
                    {
                        //MessageBox.Show("ambiente necesito que sea aquatico: " + env.ToString());
                        if (env is Aquatic || env is Aereal)
                        {
                            x++;
                            //MessageBox.Show("La entidad" + randomEntityOne.name + "es aquatico_ valor de x: " + x);
                            //MessageBox.Show("llegandooo");
                            return randomEntityOne;
                        }
                    }
                }

                if (terrain.TerrainType is Land)
                {
                    foreach (IEnvironment env in randomEntityOne.environmentList)
                    {
                        //MessageBox.Show("ambiente necesito que sea terrestre: " + env.ToString());
                        if (env is Terrestrial || env is Aereal)
                        {

                            x++;
                            //MessageBox.Show("La entidad" + randomEntityOne.name + "es terrestre valor de x: " + x);
                            //MessageBox.Show("llegandooo");
                            return randomEntityOne;
                        }
                    }

                    //el problema aca es q... si tengo terrenos en el mapa ponele de agua.. y ya ubique esas de agua en otros lados, y no me quedan mas de agua, cague porque no voy a poder ubicar mas :(
                    //para evitar estos problemas tengo que controlar que haya 9 de agua y 9 de tierra = total 18


                }
                */

            }
        
            return null;
        }


    
            
      


        public void setEntidadesEnMapa(Map map)
        {
            try { 
            List<Entity> newList = entityCtn.GetEntitiesList();
            //List<int> availableIndexes = Enumerable.Range(0, newList.Count).ToList();
            Random random = new Random();
            foreach (Terrain terr in map.TerrainsList)
            {
                //MessageBox.Show("cantidad en newList: " + newList.Count);
                List<int> availableIndexes = Enumerable.Range(0, newList.Count).ToList();


                //foreach (int e in availableIndexes)
                //{
                //MessageBox.Show("EntitiesListIndexes: " + e);
                //}


                int i = 0;
                while (i < 2) //dos entidades por terreno
                {
                    if (availableIndexes.Count > 0)
                    {


                        Entity randomEntityOne = obtenerunaentidadrandomquecoindaconelterrenodondeseubicara(terr, newList, availableIndexes);
                        //Entity randomEntityOne = newList[random.Next(availableIndexes.Count)];

                        //MessageBox.Show("entidad obtenida en metodo de seteo en terreno: " + randomEntityOne.name);
                        //MessageBox.Show("tipo de terreno: " + terr.TerrainType.ToString());

                        //if (randomEntityOne.MoveThrough(terr.TerrainType) == true)
                        //{
                        if (buscarsilaentidadyaseagregoalmapaenalgunterreno(randomEntityOne, map) == false)
                        {
                            terr.EntitiesList.Add(randomEntityOne);
                            //MessageBox.Show("en terreno: " + terr.Id + " agrega la entidad: " + randomEntityOne.name);

                            // Elimina el índice de la entidad ya agregada a un terreno
                            availableIndexes.Remove(newList.IndexOf(randomEntityOne));

                            //eliminar la entidad de la newList
                            newList.RemoveAt(newList.IndexOf(randomEntityOne));
                            i++;
                            //MessageBox.Show("valor de i despues de agregar: " + i + " en terreno: " + terr.Id);
                        }
                        //}

                    }

                }

            }
            }
            catch(Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "Aviso", "Ok", Resources.info, true);
            }
        }



        /*
        public void setPosicionablesssEnt(Map map) //funca a medias
        {
            List<Entity> newList = new List<Entity>();
            Random random = new Random();
            foreach (Terrain terr in map.TerrainsList)
            {
                
                    Entity randomEntityOne = entityCtn.GetEntitiesList()[random.Next(entityCtn.GetEntitiesList().Count)];

                    Entity randomEntityTwo = entityCtn.GetEntitiesList()[random.Next(entityCtn.GetEntitiesList().Count)];



                    if (buscarsilaentidadyaseagregoalmapaenalgunterreno(randomEntityOne, map) == false)
                    {
                        terr.EntitiesList.Add(randomEntityOne);
                        //MessageBox.Show("en terreno: " + terr.Id + " agrega la uno: " + randomEntityOne);
                        
                        if (buscarsilaentidadyaseagregoalmapaenalgunterreno(randomEntityTwo, map) == false)
                        {
                            terr.EntitiesList.Add(randomEntityTwo);
                            //MessageBox.Show("en terreno: " + terr.Id + " agrega_dos: " + randomEntityTwo);
                            
                        }
                    }
                //MessageBox.Show("cantidadPos: " + terr.PositionablesList.Count);

                //hay q busar la manera de que si devuelve true se vuelva a buscar otra entidad nueva random


                






              

                /*
                foreach (var i in terr.PositionablesList)
                {
                    MessageBox.Show("terreno: " + terr.Id + " esta: " + terr.PositionablesList.Count);
                }
                



            }
            
        }
        */



        public bool buscarsilacomidayaseagregoalmapaenalgunterreno(Food comidaAbuscar, Map map)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                if (terr.FoodsList.Contains(comidaAbuscar))
                {
                    //MessageBox.Show("la entidad: " + entidadAbuscar.name + " ya ha sido agregada en otro terreno");
                    return true;
                }

            }
            //MessageBox.Show("la entidad: " + entidadAbuscar.name + " ESTA DISPONIBLE PARA SER AGREGADA!!");
            return false;
        }

        public void setComidasEnMapa(Map map)
        {
            List<Food> newListFoods = foodCtn.GetFoodList();
            Random random = new Random();
            foreach (Terrain terr in map.TerrainsList)
            {

                List<int> availableIndexes = Enumerable.Range(0, newListFoods.Count).ToList();


                //foreach (int e in availableIndexes)
                //{
                //MessageBox.Show("EntitiesListIndexes: " + e);
                //}


                int i = 0;
                while (i < 2) //dos comidas por terreno
                {
                    if (availableIndexes.Count > 0)
                    {


                        //Entity randomFood = obtenerunaentidadrandomquecoindaconelterrenodondeseubicara(terr, newListFoods, availableIndexes);
                        Food foodRandom = newListFoods[random.Next(availableIndexes.Count)];

                        //MessageBox.Show("entidad obtenida en metodo de seteo en terreno: " + randomEntityOne.name);
                        //MessageBox.Show("tipo de terreno: " + terr.TerrainType.ToString());

                        //if (randomEntityOne.MoveThrough(terr.TerrainType) == true)
                        //{
                        if (buscarsilacomidayaseagregoalmapaenalgunterreno(foodRandom, map) == false)
                        {
                            terr.FoodsList.Add(foodRandom);
                            //MessageBox.Show("en terreno: " + terr.Id + " agrega la entidad: " + randomEntityOne.name);

                            // Elimina el índice de la entidad ya agregada a un terreno
                            availableIndexes.Remove(newListFoods.IndexOf(foodRandom));

                            //eliminar la comida de la nueavLista
                            newListFoods.RemoveAt(newListFoods.IndexOf(foodRandom));
                            i++;
                            //MessageBox.Show("valor de i despues de agregar: " + i + " en terreno: " + terr.Id);
                        }
                        //}

                    }

                }

            }
        }


        public bool buscarsielitemyaseagregoalmapaenalgunterreno(Item itemAbuscar, Map map)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                if (terr.ItemsList.Contains(itemAbuscar))
                {
                    //MessageBox.Show("la entidad: " + entidadAbuscar.name + " ya ha sido agregada en otro terreno");
                    return true;
                }

            }
            //MessageBox.Show("la entidad: " + entidadAbuscar.name + " ESTA DISPONIBLE PARA SER AGREGADA!!");
            return false;
        }

        public void setItemsEnMapa(Map map)
        {
            List<Item> newListItems = itemCtn.GetItemList();
            Random random = new Random();
            foreach (Terrain terr in map.TerrainsList)
            {

                List<int> availableIndexes = Enumerable.Range(0, newListItems.Count).ToList();


                //foreach (int e in availableIndexes)
                //{
                //MessageBox.Show("EntitiesListIndexes: " + e);
                //}


                int i = 0;
                while (i < 2) //dos comidas por terreno
                {
                    if (availableIndexes.Count > 0)
                    {


                        //Entity randomFood = obtenerunaentidadrandomquecoindaconelterrenodondeseubicara(terr, newListFoods, availableIndexes);
                        Item itemRandom = newListItems[random.Next(availableIndexes.Count)];

                        //MessageBox.Show("entidad obtenida en metodo de seteo en terreno: " + randomEntityOne.name);
                        //MessageBox.Show("tipo de terreno: " + terr.TerrainType.ToString());

                        //if (randomEntityOne.MoveThrough(terr.TerrainType) == true)
                        //{
                        if (buscarsielitemyaseagregoalmapaenalgunterreno(itemRandom, map) == false)
                        {
                            terr.ItemsList.Add(itemRandom);
                            //MessageBox.Show("en terreno: " + terr.Id + " agrega la entidad: " + randomEntityOne.name);

                            // Elimina el índice de la entidad ya agregada a un terreno
                            availableIndexes.Remove(newListItems.IndexOf(itemRandom));

                            //eliminar la comida de la nueavLista
                            newListItems.RemoveAt(newListItems.IndexOf(itemRandom));
                            i++;
                            //MessageBox.Show("valor de i despues de agregar: " + i + " en terreno: " + terr.Id);
                        }
                        //}

                    }

                }

            }
        }



        public void setBorderingTerrains(Map map)
        {
            map.TerrainsList[0].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[1], map.TerrainsList[5], map.TerrainsList[6] };
            map.TerrainsList[1].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[0], map.TerrainsList[6], map.TerrainsList[7], map.TerrainsList[2] };
            map.TerrainsList[2].BorderingTerrainsList = new List<Terrain> { map.TerrainsList[1], map.TerrainsList[7], map.TerrainsList[3] };
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


        public bool MoverEntidadAunTerreno(Entity entity, Terrain terrenoActual, Terrain terrenoAdondeSeMovera)
        {
            if (chequearQueUnTerrenoEnParticularSeaLimitrofeDelTerrenoActualSeleccionado(terrenoActual, terrenoAdondeSeMovera) == true)
            {
                if (entity.MoveThrough(terrenoAdondeSeMovera.TerrainType))
                {
                    eliminarUnaEntidadDeUnTerreno(entity, terrenoActual);


                    //luego agregarla a el terreno donde se va a mover
                    agregarEntidadAlTerrenoDondeSeMovio(entity, terrenoAdondeSeMovera);
                    return true;
                }
            }
            return false;
        }


        public void eliminarUnaEntidadDeUnTerreno(Entity entity, Terrain terr)
        {
            terr.EntitiesList.Remove(entity);
        }


        public void agregarEntidadAlTerrenoDondeSeMovio(Entity entity, Terrain terr)
        {
            terr.EntitiesList.Add(entity);
            new MessageBoxDarkMode("La entidad "+entity.name+" se ha movido al terreno N°"+terr.Id+ " con éxito!!", "ATENCIÓN", "Ok", Resources.check, true);
        }

        public bool chequearQueUnTerrenoEnParticularSeaLimitrofeDelTerrenoActualSeleccionado(Terrain terrenoActual, Terrain posibleTerrenoLimitrofe)
        {
            if (terrenoActual.BorderingTerrainsList.Contains(posibleTerrenoLimitrofe)==true)
            {
                return true;
            }
            else
            {
                throw new Exception("No se puede mover la entidad hasta el terreno N°" + posibleTerrenoLimitrofe.Id + " (esta muy lejos). Recuerde solo podra moverse en los terrenos limitrofes (bordes de color naranja)");
            }
        }




        public void eliminarDelMapaUnaEntidadqMurio(Entity entity, Map map)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                //MessageBox.Show("cantidad en lista antes de borrar: " + terr.EntitiesList.Count + "en terreno "+terr.Id);
                if (terr.EntitiesList.Contains(entity))
                {
                    
                    terr.EntitiesList.Remove(entity);//borra la entidad del terreno donde se encuentre
                    //MessageBox.Show("cantidad en lista DESPUES DE de borrar: " + terr.EntitiesList.Count + " la entidad "+entity.name);
                }

            }

        }

        public void eliminarDelMapaUnItemUtilizado(Item item, Map map)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                //MessageBox.Show("cantidad en lista antes de borrar: " + terr.EntitiesList.Count + "en terreno " + terr.Id);
                if (terr.ItemsList.Contains(item))
                {

                    terr.ItemsList.Remove(item);//borra la entidad del terreno donde se encuentre
                    //MessageBox.Show("cantidad en lista DESPUES DE de borrar: " + terr.EntitiesList.Count + " la entidad " + item.name);
                }

            }

        }


        public void eliminarDelMapaUnaComidaIngerida(Food food, Map map)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                //MessageBox.Show("cantidad en lista antes de borrar: " + terr.FoodsList.Count + "en terreno " + terr.Id);
                if (terr.FoodsList.Contains(food))
                {

                    terr.FoodsList.Remove(food);//borra la entidad del terreno donde se encuentre
                    //MessageBox.Show("cantidad en lista DESPUES DE de borrar: " + terr.FoodsList.Count + " la entidad " + food.name);
                    
                }
                    
            }
               
        }


        public bool CheckIfAnyEntityDiedAfterTheAttack(Entity entidadAtacante, Entity entidadAtacada)
        {
            int finalResult = entidadAtacante.FinallyResolveTheAttack(entidadAtacada);
            if (finalResult == 1)
            {
                Message.ShowMessageBoxDarkMode(entidadAtacada.name + " mató a " + entidadAtacante.name + "!!!", "ATENCIÓN", "Ok", Resources.ko);
                eliminarDelMapaUnaEntidadqMurio(entidadAtacante, GetMap());
                return true;
            }
            else
            {
                if (finalResult == 2)
                {
                    Message.ShowMessageBoxDarkMode(entidadAtacante.name + " mató a " + entidadAtacada.name + "!!!", "ATENCIÓN", "Ok", Resources.ko);
                    eliminarDelMapaUnaEntidadqMurio(entidadAtacada, GetMap());
                    return true;
                }
            }
            return false;
        } 
    }
}
