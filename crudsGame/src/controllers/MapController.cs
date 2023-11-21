using crudsGame.Properties;
using crudsGame.src.factoryMethod;
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
using MessageBox = crudsGame.src.model.MessageBox;

namespace crudsGame.src.controllers
{
    internal class MapController
    {
        private EntityController entityCtn = EntityController.getInstance();
        private FoodController foodCtn = FoodController.getInstance();
        private ItemController itemCtn = ItemController.getInstance();
        private static MapController instance;
        private readonly Map map = new Map();
        int AvoidInfiniteLoop = 0;

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
            map.TerrainsList.Add(TerrainToAdd);    
        }

        public List<Terrain> GetTerrains(Map map)
        {
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
            terrainTypesList.Add(TerrainCreator.CreateAterrain(1));
            terrainTypesList.Add(TerrainCreator.CreateAterrain(2));
            return terrainTypesList;
        }


        public bool GenerateMap()
        {
            if (CheckIfThereAreFortyEntitiesFoodsAndItems() == true)
            {
                var random = new Random();
                for (int i = 0; i < 19; i++)
                {
                    List<ITerrain> terrainTypes = TerrainsTypesList();
                    ITerrain randomTerrain = terrainTypes[random.Next(terrainTypes.Count)];
                    AddTerrain(randomTerrain, map);
                }
                SetBorderingTerrains(); 
                SetEntities();
                SetFoods();
                SetItems();
                return true;
            }
            return false;
        
        }

        public bool CheckIfThereAreFortyEntitiesFoodsAndItems()
        {
            if ((entityCtn.GetEntitiesList().Count < 40) || (foodCtn.GetFoodList().Count < 40) || (itemCtn.GetItemList().Count < 40))
            {
                throw new Exception("Para poder generar el mapa deben existir 40 entidades, 40 comidas y 40 items. Por favor verifique en los CRUDs que haya creado esta cantidad.");  
            }
            return true;   
        }

        public void SetBorderingTerrains()
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

        #region Set Entities in the Map
        /// <summary>
        /// Busca si una entidad random ya ha sido agregada en el mapa sobre algun terreno
        /// </summary>
        public bool SearchIfTheEntityHasAlreadyBeenAddedToTheMapInSomeTerrain(Entity entityToSearch)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                if (terr.EntitiesList.Contains(entityToSearch))
                {
                    //MessageBox.Show("la entidad: " + entidadAbuscar.name + " ya ha sido agregada en otro terreno");
                    return true;
                }

            }
            //MessageBox.Show("la entidad: " + entidadAbuscar.name + " ESTA DISPONIBLE PARA SER AGREGADA!!");
            return false;
        }


      

        /// <summary>
        /// Obtiene una entidad random donde su ambiente coincida con el terreno donde se ubicará
        /// </summary>
        private Entity GetArandomEntityWhereItsEnvironmentMatchesTheTerrainWhereItWillBeLocated(Terrain terrain, List<Entity> newList, List<int> availableIndexes)
        {
            int x = 0;
            Random random = new Random();
            while (x != 1)
            {
                x = 0;
              
                // Se elije un indice random de la lista de indices disponibles para agregar de la lista de entidades
                int indexRandom = random.Next(availableIndexes.Count);
                //MessageBox.Show("index random: " + indexrandmom+ " _cantidad en la newList: "+newList.Count+" cantidad de indices disponibles: "+availableIndexes.Count);

                // Aca de la lista de entidades que seria newList se le asigna entre corchetes el index anterior para obtener una entidad random
                Entity EntityRandom = newList[indexRandom];
                /*
                MessageBox.Show("trabajando con: " + randomEntityOne.name);
                */

                switch (terrain.TerrainType)
                {
                    case Water: // --> Si el terreno es agua
                        foreach (IEnvironment env in EntityRandom.environmentList) 
                        {
                            if (AvoidInfiniteLoop != 50)
                            {
                                if (env is Aquatic || env is Aereal) // --> Si en la lista de ambientes de la entidad random obtenida anteriormente tiene a acuatico o aereo
                                {
                                    x++;// --> Corta el ciclo x = 1 
                                    return EntityRandom; // --> Retorna la entidad para que pueda ser agregada
                                }
                                AvoidInfiniteLoop++;
                            }
                            else
                            {
                                throw new Exception("Algunas de las entidades creadas no podrán colocarse sobre los terrenos aleatorios generados debido a que en su propia lista de ambientes, no coinden con los terrenos que se encontraban libres para ocupar...");
                            }
                        }
                        break;
                    case Land:
                        foreach (IEnvironment env in EntityRandom.environmentList)
                        {
                            if (AvoidInfiniteLoop != 50)
                            {
                                if (env is Terrestrial || env is Aereal)
                                {
                                    x++;
                                    return EntityRandom;
                                }
                                AvoidInfiniteLoop++;
                            }
                            else
                            {
                                throw new Exception("Algunas de las entidades creadas no podrán colocarse sobre los terrenos aleatorios generados debido a que en su propia lista de ambientes, no coinden con los terrenos que se encontraban libres para ocupar...");
                            }
                        }
                        break;
                }
            }
            return null;
        }


   
        public void SetEntities()
        {
            try 
            { 
                List<Entity> newList = entityCtn.GetEntitiesList();
                Random random = new Random();
                foreach (Terrain terr in map.TerrainsList)
                {
                    List<int> availableIndexes = Enumerable.Range(0, newList.Count).ToList();
                    int i = 0;
                    while (i < 2) // --> Dos entidades por terreno
                    {
                        if (availableIndexes.Count > 0)
                        {
                            Entity randomEntityOne = GetArandomEntityWhereItsEnvironmentMatchesTheTerrainWhereItWillBeLocated(terr, newList, availableIndexes);
                        
                            if (SearchIfTheEntityHasAlreadyBeenAddedToTheMapInSomeTerrain(randomEntityOne) == false)
                            {
                                terr.EntitiesList.Add(randomEntityOne);
                                //MessageBox.Show("en terreno: " + terr.Id + " agrega la entidad: " + randomEntityOne.name);

                                // Elimina el índice de la entidad ya agregada a un terreno
                                availableIndexes.Remove(newList.IndexOf(randomEntityOne));

                                // Eliminar la entidad de la newList
                                newList.RemoveAt(newList.IndexOf(randomEntityOne));
                                i++;
                            }
                        }

                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", "Ok", Resources.info);
            }
        }
        #endregion


        #region Set Foods in the Map
        /// <summary>
        /// Busca si una comida random ya ha sido agregada en el mapa sobre algun terreno
        /// </summary>
        public bool SearchIfTheFoodHasAlreadyBeenAddedToTheMapInSomeTerrain(Food foodToSearch)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                if (terr.FoodsList.Contains(foodToSearch))
                {
                    return true;
                }
            }
            return false;
        }

        public void SetFoods()
        {
            List<Food> newListFoods = foodCtn.GetFoodList();
            Random random = new Random();
            foreach (Terrain terr in map.TerrainsList)
            {
                List<int> availableIndexes = Enumerable.Range(0, newListFoods.Count).ToList();
                int i = 0;
                while (i < 2) // --> Dos comidas por terreno
                {
                    if (availableIndexes.Count > 0)
                    {
                        Food foodRandom = newListFoods[random.Next(availableIndexes.Count)];

                        if (SearchIfTheFoodHasAlreadyBeenAddedToTheMapInSomeTerrain(foodRandom) == false)
                        {
                            terr.FoodsList.Add(foodRandom);
                            availableIndexes.Remove(newListFoods.IndexOf(foodRandom));
                            newListFoods.RemoveAt(newListFoods.IndexOf(foodRandom));
                            i++;
                        }
                    }

                }

            }
        }
        #endregion

        
        #region Set Items in the Map
        /// <summary>
        /// Busca si un item random ya ha sido agregado en el mapa sobre algun terreno
        /// </summary>
        public bool SearchIfTheItemHasAlreadyBeenAddedToTheMapInSomeTerrain(Item itemToSearch)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                if (terr.ItemsList.Contains(itemToSearch))
                {
                    return true;
                }

            }
            return false;
        }

        public void SetItems()
        {
            List<Item> newListItems = itemCtn.GetItemList();
            Random random = new Random();
            foreach (Terrain terr in map.TerrainsList)
            {
                List<int> availableIndexes = Enumerable.Range(0, newListItems.Count).ToList();
                int i = 0;
                while (i < 2) // --> Dos items por terreno
                {
                    if (availableIndexes.Count > 0)
                    {
                        Item itemRandom = newListItems[random.Next(availableIndexes.Count)];

                        if (SearchIfTheItemHasAlreadyBeenAddedToTheMapInSomeTerrain(itemRandom) == false)
                        {
                            terr.ItemsList.Add(itemRandom);
                            availableIndexes.Remove(newListItems.IndexOf(itemRandom));
                            newListItems.RemoveAt(newListItems.IndexOf(itemRandom));
                            i++;
                            
                        }
                    }
                }
            }
        }
        #endregion


        #region Move Entity in the Map
        /// <summary>
        /// Verifica si el terreno donde se va a mover es limitrofe del terreno donde se encuentra actualmente la entidad
        /// </summary>
        public bool VerifyThatATerrainIsBorderingTheCurrentSelectedTerrain(Terrain currentTerrain, Terrain terrainToMove)
        {
            if (currentTerrain.BorderingTerrainsList.Contains(terrainToMove))
            {
                return true;
            }
            else
            {
                throw new Exception("No se puede mover la entidad hasta el terreno N°" + terrainToMove.Id + " (esta muy lejos). Recuerde solo podra moverse en los terrenos limitrofes (bordes de color naranja)");
            }
        }

        public bool MoveEntitiyToTerrain(Entity entity, Terrain currentTerrain, Terrain terrainToMove)
        {
            if (VerifyThatATerrainIsBorderingTheCurrentSelectedTerrain(currentTerrain, terrainToMove))
            {
                if (entity.MoveThrough(terrainToMove.TerrainType))
                {
                    RemoveAnEntityFromAterrain(entity, currentTerrain);
                    AddEntityToTerrainWhereMoved(entity, terrainToMove); // --> Luego agrega la entidad al terreno donde se va a mover
                    return true;
                }
            }
            return false;
        }


        public void RemoveAnEntityFromAterrain(Entity entity, Terrain terr)
        {
            terr.EntitiesList.Remove(entity);
        }


        public void AddEntityToTerrainWhereMoved(Entity entity, Terrain terr)
        {
            terr.EntitiesList.Add(entity);
            GeneralController.PlaySoundEffect(Resources.move);
            MessageBox.Show("La entidad "+entity.name+" se ha movido al terreno N°"+terr.Id+ " con éxito!!", "ATENCIÓN", "Ok", Resources.check);
        }
        #endregion


        #region Remove Objects from the Map
        public void RemoveAnEntityFromTheMap(Entity entity)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                if (terr.EntitiesList.Contains(entity))
                {
                    RemoveAnEntityFromAterrain(entity, terr);
                    break;
                }
            }
        }

        public void RemoveAusedItemFromTheMap(Item item)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                if (terr.ItemsList.Contains(item))
                {
                    terr.ItemsList.Remove(item);
                    break;
                }
            }
        }


        public void RemoveAnEatenFoodFromTheMap(Food food)
        {
            foreach (Terrain terr in map.TerrainsList)
            {
                if (terr.FoodsList.Contains(food))
                {
                    terr.FoodsList.Remove(food);
                    break;
                }        
            }
        }
        #endregion

        
        /// <summary>
        /// Chequea si la entidad atacante o la entidad atacada murió despues de realizar el ataque
        /// asi despues borra del mapa alguna de las entidades
        /// </summary>
        public void ResolveAttack(Entity attackingEntity, Entity attackedEntity)
        {
            if (attackingEntity.Attack(attackedEntity)) // --> Entidad atacante GANA 
            {
                if (!attackedEntity.IsAlive())
                {
                    GeneralController.PlaySoundEffect(Resources.murio);
                    MessageBox.Show(attackingEntity.name + " mató a " + attackedEntity.name + "!!!", "ATENCIÓN", "Ok", Resources.ko);
                    RemoveAnEntityFromTheMap(attackedEntity); // --> Entidad atacada se muere
                }
            }
            else // --> Entidad atacada PIERDE
            {
                if (!attackingEntity.IsAlive())
                {
                    GeneralController.PlaySoundEffect(Resources.murio);
                    MessageBox.Show(attackedEntity.name + " mató a " + attackingEntity.name + "!!!", "ATENCIÓN", "Ok", Resources.ko);
                    RemoveAnEntityFromTheMap(attackingEntity); // --> Entidad atacante se muere
                }     
            }           
        }
    }
}
