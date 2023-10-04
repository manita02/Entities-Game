using crudsGame.src.interfaces;
using crudsGame.src.model.Terrains;
using crudsGame.src.model.Terrains.Map;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.controllers
{
    internal class TerrainController
    {
        private static TerrainController instance;
        private readonly List<Terrain> TerrainList = new List<Terrain>();
        private TerrainController() { }
        public static TerrainController GetInstance()
        {
            if (instance == null)
            {
                instance = new TerrainController();
            }
            return instance;
        }
        public void AddTerrain(ITerrain terrainType) 
        {
            Terrain NewTerrain = new Terrain(terrainType); //creo un nuevo terreno y le asigno su tipo de terreno
            TerrainList.Add(NewTerrain); // y lo agrego a la lista de terrenos
        }
        /*
        public void AddBorderingTerrain(Terrain terrainToModify, List<Terrain> BorderingTerrainsToAdd)
        {
            foreach (Terrain terrain in BorderingTerrainsToAdd)
            {
                terrainToModify.BorderingTerrain.Add(terrain);
            }
        }
        */
        public void AddBorderingTerrain(Terrain terrainToModify, Terrain BorderingTerrainToAdd) //usa este
        {
            terrainToModify.BorderingTerrainsList.Add(BorderingTerrainToAdd); //a un terreno le agrega terreno limitrofe a su propia lista de terrenos limitrofes
        }
        public List<Terrain> GetTerrainList()
        {
            return TerrainList;
        }

        /*
        public List<IPositionable> getPositionbalesInAllLands()
        {
            List<IPositionable> allPositionables = new List<IPositionable>();
            foreach (Land land in TerrainList)
            {
                allPositionables.AddRange(land.Positionables);
            }
            return allPositionables;
        }
        */

        public List<Terrain> GetBorderingTerrainsList(Terrain terrain)
        {
            return terrain.BorderingTerrainsList; //obtiene la lista de terrenos limitrofes de un terreno en particular
        }

        /*
        public void Update(Land landToModify, Land landModified)
        {

            int index = TerrainList.FindIndex(e => e == landToModify);

            if (index != -1)
            {
                TerrainList[index] = landModified;
            }
        }
        */

       
        public void setBorderingLands() //asiga a cada uno de los terrenos de la lista su propios terrenos limitrofes
        {
            var random = new Random(); //generacion de numero random

            foreach (Terrain terrain in TerrainList)
            {
                //cantidad de tierras limitrofes entre 1 y 6
                int numberBorderingTerrainsToAdd = random.Next(1, 7); //aca puede salir un 2, un 3 o un 6, pero no superarlo, si sale 2 le agregara dos tierras limitrofes
                MessageBox.Show("cantidad de tierras limitrofes q agregara: " + numberBorderingTerrainsToAdd + " que añadira al terreno: " + terrain.ToString());

                List<int> availableTerrainsIndexesList = Enumerable.Range(0, TerrainList.Count).ToList(); //Trae los indices de la lista de terrenos disponibles (0,1,2,3,4)
                /*
                foreach (int e in availableTerrainsIndexesList)
                {
                    MessageBox.Show("TerrainsListIndexes: " + e);
                }
                */


                // Elimina el índice de la tierra actual de las tierras disponibles para que no limite con ella misma
                availableTerrainsIndexesList.Remove(TerrainList.IndexOf(terrain));
                //MessageBox.Show("cantidad de terrenos disponibles: " + availableTerrainsIndexesList + " menos el terreno actual: " + TerrainList.IndexOf(terrain));

                /*
                int x = 0;
                while (x < numberBorderingTerrainsToAdd)
                {
                    if (availableTerrainsIndexesList.Count > 0)
                    {
                        //elige aleatoriamente una tierra entre las tierras limitrofes
                        int randomIndex = random.Next(0, availableTerrainsIndexesList.Count);//se obtiene un indice aleatorio de la lista de terrenos (que esos indices se guardaron en availableTerrainsIndexesList)
                        MessageBox.Show("index random q luego se buscara en los terrenos limitrofes: " + randomIndex);
                        //ponele q sale 2


                        //asigna a una variable entera el indice de la tierra.
                        int borderingTerrainIndex = availableTerrainsIndexesList[randomIndex];//guardame de la lista de indexes, el numero que esta en la posicion 2
                        MessageBox.Show("El terreno posible que agregara sera: " + TerrainList[borderingTerrainIndex]);


                        // Verifica si la tierra limitrofe ya ha sido agregada y si no exceden ninguna de las dos tierras el límite de tener 6 límitrofes

                        //si el terreno NO contiene en su lista de terrenos limitrofes a (el numero (posicion) que se guardo en borderingTerrainIndex) && 
                        //      la lista de terrenos limitrofes de ese terreno que esta en el for es menor 6 en cantidad && 
                        //      de la lista de terrenos generada, en la posicion bonderingTerrainIndex de la lista, osea ese terreno en esa posicion, tiene menos de 6 en su lista de terrenos limitrofes.. -> entra al if

                        if (terrain.BorderingTerrainsList.Contains(TerrainList[borderingTerrainIndex])){
                            MessageBox.Show("el terreno id: " + terrain.Id + " ya contiene a " + TerrainList[borderingTerrainIndex].Id + " en su lista de terrenos limitrofes");
                        }
                        else
                        {
                            if(terrain.BorderingTerrainsList.Count > 6)
                            {
                                MessageBox.Show("el terreno: " + terrain.ToString() + "ya contiene su numero max (6) en terrenos limitrofes"); 
                            }
                            else
                            {
                                if (TerrainList[borderingTerrainIndex].BorderingTerrainsList.Count > 6)
                                {
                                    MessageBox.Show("el terreno: " + TerrainList[borderingTerrainIndex] + "ya contiene su numero max (6) en terrenos limitrofes");
                                }
                                else
                                {
                                    MessageBox.Show("finalmente agrega este limitrofe: " + TerrainList[borderingTerrainIndex].ToString() + " al terreno: " + terrain.ToString());
                                    // Agrega la tierra limitrofe y visceversa
                                    AddBorderingTerrain(terrain, TerrainList[borderingTerrainIndex]);//al terreno q va en el for, el agrega su limitrofe
                                    AddBorderingTerrain(TerrainList[borderingTerrainIndex], terrain);// al terreno limitrofe, le agrega el terreno que va en el for
                                    x++;

                                }
                            }

                        }



                        cacaaaa
                        if (!terrain.BorderingTerrainsList.Contains(TerrainList[borderingTerrainIndex]) && terrain.BorderingTerrainsList.Count < 6 && TerrainList[borderingTerrainIndex].BorderingTerrainsList.Count < 6)
                        { //reducir estos if y ver xq no entra
                            MessageBox.Show("finalmente agrega este limitrofe: " + TerrainList[borderingTerrainIndex].ToString() + " al terreno: " + terrain.ToString());
                            // Agrega la tierra limitrofe y visceversa
                            AddBorderingTerrain(terrain, TerrainList[borderingTerrainIndex]);//al terreno q va en el for, el agrega su limitrofe
                            AddBorderingTerrain(TerrainList[borderingTerrainIndex], terrain);// al terreno limitrofe, le agrega el terreno que va en el for
                            x++;
                        }
                        
                    }

                }
                */
                
                for (int i = 0; i < numberBorderingTerrainsToAdd; i++)
                {
                    if (availableTerrainsIndexesList.Count > 0)
                    {
                        //elige aleatoriamente una tierra entre las tierras limitrofes
                        int randomIndex = random.Next(0, availableTerrainsIndexesList.Count);//se obtiene un indice aleatorio de la lista de terrenos (que esos indices se guardaron en availableTerrainsIndexesList)
                        //MessageBox.Show("index random q luego se buscara en los terrenos limitrofes: " + randomIndex);
                        //ponele q sale 2


                        //asigna a una variable entera el indice de la tierra.
                        int borderingTerrainIndex = availableTerrainsIndexesList[randomIndex];//guardame de la lista de indexes, el numero que esta en la posicion 2
                        //MessageBox.Show("El terreno posible que agregara sera: " + TerrainList[borderingTerrainIndex]);


                        // Verifica si la tierra limitrofe ya ha sido agregada y si no exceden ninguna de las dos tierras el límite de tener 6 límitrofes

                        //si el terreno NO contiene en su lista de terrenos limitrofes a (el numero (posicion) que se guardo en borderingTerrainIndex) && 
                        //      la lista de terrenos limitrofes de ese terreno que esta en el for es menor 6 en cantidad && 
                        //      de la lista de terrenos generada, en la posicion bonderingTerrainIndex de la lista, osea ese terreno en esa posicion, tiene menos de 6 en su lista de terrenos limitrofes.. -> entra al if

                        if (terrain.BorderingTerrainsList.Contains(TerrainList[borderingTerrainIndex]))
                        {
                            //MessageBox.Show("el terreno id: " + terrain.Id + " ya contiene a " + TerrainList[borderingTerrainIndex].Id + " en su lista de terrenos limitrofes");
                        }
                        else
                        {
                            if (terrain.BorderingTerrainsList.Count > 6)
                            {
                                //MessageBox.Show("el terreno: " + terrain.ToString() + "ya contiene su numero max (6) en terrenos limitrofes");
                            }
                            else
                            {
                                if (TerrainList[borderingTerrainIndex].BorderingTerrainsList.Count > 6)
                                {
                                    //MessageBox.Show("el terreno (limitrofe): " + TerrainList[borderingTerrainIndex] + "ya contiene su numero max (6) en terrenos limitrofes");
                                }
                                else
                                {
                                    //MessageBox.Show("finalmente agrega este limitrofe: " + TerrainList[borderingTerrainIndex].ToString() + " al terreno: " + terrain.ToString());
                                    // Agrega la tierra limitrofe y visceversa
                                    AddBorderingTerrain(terrain, TerrainList[borderingTerrainIndex]);//al terreno q va en el for, el agrega su limitrofe
                                    AddBorderingTerrain(TerrainList[borderingTerrainIndex], terrain);// al terreno limitrofe, le agrega el terreno que va en el for
                                    //x++;

                                }
                            }

                        }

                        /*
                        if (!terrain.BorderingTerrainsList.Contains(TerrainList[borderingTerrainIndex]) && terrain.BorderingTerrainsList.Count < 6 && TerrainList[borderingTerrainIndex].BorderingTerrainsList.Count < 6)
                        {
                            MessageBox.Show("finalmente agrega este limitrofe: " + TerrainList[borderingTerrainIndex].ToString() + " al terreno: " + terrain.ToString());
                            // Agrega la tierra limitrofe y visceversa
                            AddBorderingTerrain(terrain, TerrainList[borderingTerrainIndex]);//al terreno q va en el for, el agrega su limitrofe
                            AddBorderingTerrain(TerrainList[borderingTerrainIndex], terrain);// al terreno limitrofe, le agrega el terreno que va en el for

                        }
                        */
                    }
                }
                
                foreach (var e in terrain.BorderingTerrainsList)
                {
                    MessageBox.Show("terreno agregado: " +e.ToString());
                }
            }
        }
        /*
        public List<IPositionable> GetPositionablesInLand(Land land)
        {
            return land.Positionables;
        }
        */
    }
}
