using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static crudsGame.src.views.MaterialUI;
using MaterialSkin.Controls;
using crudsGame.Properties;
using crudsGame.src.controllers;
using crudsGame.src.model.Map.Terrains;
using crudsGame.src.model;
using crudsGame.src.model.Items;
using crudsGame.src.interfaces;
using crudsGame.src.model.Foods;
using crudsGame.src.model.Map;

namespace crudsGame.src.views
{
    public partial class MapTest : MaterialForm
    {
        List<HexagonControl> hexagonsList = new List<HexagonControl>();
        MapController mapController = MapController.GetInstance();

        public MapTest()
        {
            InitializeComponent();
            LoadMaterial(this);
            AddHexagonsToList();
            SetHexagonClickWithBorderingTerrains();
            AddNumbersToHexagons();
            CheckIfAmapAlreadyExists();
        }

        private void AddNumbersToHexagons()
        {
            for (int i = 0; i < hexagonsList.Count(); i++)
            {
                hexagonsList[i].HexagonText = $"{i}";
            }
        }

        private void AddHexagonsToList()
        {
            hexagonsList.AddRange(new List<HexagonControl>
            {
                hex0, hex1, hex2, hex3, hex4, hex5,
                hex6, hex7, hex8, hex9, hex10, hex11,
                hex12, hex13, hex14, hex15, hex16, hex17,
                hex18
            });
            /*
            int i = 0;
            foreach (var hexagon in hexagonsList)
            {
                //MessageBox.Show("nombre: " + hexagon.Name + ", index: " + i);
                i++;
            }
            */
        }


        private void SetHexagonClickWithBorderingTerrains()
        {
            foreach (var hexagon in hexagonsList)
            {
                //MessageBox.Show(hexagon.Name);
                hexagon.Click += Hexagon_Click;
            }
        }

        private void Hexagon_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Si el panel de movimiento no esta visible ejecutar el hexagonclick donde se muestran los terrenos limitrofes
            /// (bordes en color amarillo y naranja)
            /// </summary>
            if (pnMove.Visible == false)
            {
                HexagonControl clickedHexagon = sender as HexagonControl;

                int index = hexagonsList.IndexOf(clickedHexagon);
                hexagonsList[index].Enabled = true;
                //MessageBox.Show("indice hxagono clikeado: " + index);
                cbCurrentTerrain.SelectedIndex = index;
                //MessageBox.Show("index en combo currentTerrain: " + cbCurrentTerrain.SelectedIndex);
                ChangeColorOfSelectedHexagonAndTheirBorderingHexagons(mapController.GetTerrains(mapController.GetMap())[index]);
            }

        }

        private void ResetHexagonBorderColor()
        {
            foreach (var hexagon in hexagonsList)
            {
                hexagon.BorderColor = SystemColors.ControlText; // Utiliza el color original del borde
            }
        }

        private void ChangeColorOfSelectedHexagonAndTheirBorderingHexagons(Terrain terrain)
        {
            ResetHexagonBorderColor();
            hexagonsList[terrain.Id].BorderColor = Color.Yellow; // Terreno Actual Seleccionado
            //MessageBox.Show("terreno que debe coindir: " + terrain.ToString());
            for (int i = 0; i < terrain.BorderingTerrainsList.Count(); i++)
            {
                hexagonsList[terrain.BorderingTerrainsList[i].Id].BorderColor = Color.DarkOrange; // Terrenos limitrofes del seleccionado anteriormente
            }
        }

        /// <summary>
        /// Si ya existe un mapa creado, directamente carga ese unico mapa y evita la posibilidad de generar nuevos mapas
        /// Si llegase a ser requerimiento crear más de un mapa, esto ya no sirve
        /// Si no es asi, modificar en la clase Map.cs que pide una lista de mapas ya que no es necesario
        /// </summary>
        private void CheckIfAmapAlreadyExists()
        {
            if (mapController.GetMap().TerrainsList.Count > 0) //esto esta al pedo xq una vez creado el mapa ya no podra volver al menu principal
            {
                LoadMap();
            }
            else
            {
                if (mapController.GenerateMap() == true)
                {
                    LoadMap();
                }
            }
        }

        private void LoadMap()
        {
            //cbMaps.Items.Add(mapController.GetMap());
            //cbMaps.SelectedIndex = 0;
            cbCurrentTerrain.DataSource = mapController.GetTerrains(mapController.GetMap());
            lbBonderingTerrains.DataSource = mapController.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem);

            //cbMaps.SelectedIndex = 0;
            PaintHexagons();
            btnGenerateMap.Enabled = false;

        }

        private void PaintHexagons()
        {
            List<Terrain> terrainsList = mapController.GetTerrains(mapController.GetMap());

            for (int i = 0; i < hexagonsList.Count(); i++)
            {
                hexagonsList[i].BackColor = terrainsList[i].TerrainType.getColor();
            }
        }



        #region Load Listboxs
        private void AddEntitiesToListbox(List<Entity> entitiesList, ListBox listbox)
        {
            foreach (Entity entity in entitiesList)
            {
                listbox.Items.Add(entity);
            }
        }


        private void LoadListboxOfEntitiesToAttack()
        {

            lbEntitiesToAttack.Items.Clear();
            if (((Entity)lbEntitiesOnAterrain.SelectedItem).attackRange == 1)
            {
                /// <summary>
                /// Recorre los terrenos limitrofes del terreno actual seleccionado y ejecuta el metodo donde le pasa como
                /// parametro la lista de entidades que tiene cada uno de los terrenos limitrofes
                /// </summary>
                foreach (Terrain terr in ((Terrain)cbCurrentTerrain.SelectedItem).BorderingTerrainsList)//terrenos limitrofes del terreno actual
                {
                    AddEntitiesToListbox(terr.EntitiesList, lbEntitiesToAttack);
                }

                /// <summary>
                /// Llama a este metodo y le pasa la lista de entidades que tiene el terreno actual
                /// </summary>
                AddEntitiesToListbox(((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList, lbEntitiesToAttack); //entidades en terreno actual
                /*
                foreach (Entity entity in ((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList)
                {
                    lbEntitiesToAttack.Items.Add(entity);
                }
                */
            }
            else if (((Entity)lbEntitiesOnAterrain.SelectedItem).attackRange == 0)
            {
                /// <summary>
                /// Llama a este metodo y le pasa la lista de entidades que tiene el terreno actual
                /// </summary>
                AddEntitiesToListbox(((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList, lbEntitiesToAttack); //entidades en terreno actual
                /*
                foreach (Entity entity in ((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList)
                {
                    lbEntitiesToAttack.Items.Add(entity);
                }
                */
            }

            lbEntitiesToAttack.Items.Remove((Entity)lbEntitiesOnAterrain.SelectedItem);//elimina el seleccionado

            if (lbEntitiesToAttack.Items.Count > 0)
            {
                lbEntitiesToAttack.SelectedIndex = 0;
            }

        }

        public void LoadListBoxOfFoodsOnAcurrentTerrain()
        {
            lbFoodsOnAterrain.Items.Clear();


            foreach (Food food in ((Terrain)cbCurrentTerrain.SelectedItem).FoodsList)
            {
                lbFoodsOnAterrain.Items.Add(food);
            }
        }

        public void LoadListBoxOfItemsOnAcurrentTerrain()
        {
            lbItemsOnAterrain.Items.Clear();


            foreach (Item item in ((Terrain)cbCurrentTerrain.SelectedItem).ItemsList)
            {
                lbItemsOnAterrain.Items.Add(item);
            }
        }

        public void LoadListBoxOfEntitiesOnAcurrentTerrain()
        {
            lbEntitiesOnAterrain.Items.Clear();
            AddEntitiesToListbox(((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList, lbEntitiesOnAterrain);
            /*
            foreach (Entity creatures in ((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList)
            {
                lbEntitiesOnAterrain.Items.Add(creatures);
            }
            */
            if (lbEntitiesOnAterrain.Items.Count > 0)
            {
                lbEntitiesOnAterrain.SelectedIndex = 0;
            }

        }
        #endregion


        #region Load Progress Bars
        private void LoadProgressbarOfSelectedEntity()
        {

            lbCurrentLife.Text = "🖤Current Life🖤 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).currentLife;
            pbCurrentLife.Maximum = ((Entity)lbEntitiesOnAterrain.SelectedItem).maxLife;
            pbCurrentLife.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).currentLife;


            lbCurrentEnergy.Text = "⚡Current Energy⚡ = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).currentEnergy;
            pbCurrentEnergy.Maximum = ((Entity)lbEntitiesOnAterrain.SelectedItem).maxEnergy;
            pbCurrentEnergy.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).currentEnergy;

            lbAttack.Text = "💣Attack Points💣 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).attackPoints;
            pbAttackPoints.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).attackPoints;

            lbDefense.Text = "🛡️Defense Points🛡️ = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).defensePoints;
            pbDefensePoints.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).defensePoints;

        }

        private void LoadProgressbarOfEntitiesToAttackPlayerTwo()
        {
            if (lbEntitiesToAttack.Items.Count > 0)
            {
                pnAttack.Enabled = true;
                lbCurrentLifePlayerTwo.Text = "⚔️Current Life⚔️ = " + ((Entity)lbEntitiesToAttack.SelectedItem).currentLife;
                pbCurrentLifePlayerTwo.Maximum = ((Entity)lbEntitiesToAttack.SelectedItem).maxLife;
                pbCurrentLifePlayerTwo.Value = ((Entity)lbEntitiesToAttack.SelectedItem).currentLife;
            }
            else
            {
                lbCurrentLifePlayerTwo.Text = "⚔️Current Life⚔️ = 0 ";
                pbCurrentLifePlayerTwo.Value = 0;
                pnAttack.Enabled = false;
            }

        }

        #endregion


        #region Buttons Interactions
        private void btnGenerateMap_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (mapController.GenerateMap() == true)
            {
                LoadMap();
            }

            //}
            //catch (Exception ex)
            //{
            //new MessageBoxDarkMode(ex.Message, "Error", "Ok", Resources.error, true);
            //}

        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Entity)lbEntitiesOnAterrain.SelectedItem).Eat(((Food)lbFoodsOnAterrain.SelectedItem)) == true)
                {
                    mapController.eliminarDelMapaUnaComidaIngerida((Food)lbFoodsOnAterrain.SelectedItem, mapController.GetMap());
                    LoadListBoxOfFoodsOnAcurrentTerrain();
                    LoadProgressbarOfSelectedEntity();


                }


            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                LoadProgressbarOfSelectedEntity();
            }

        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Entity)lbEntitiesOnAterrain.SelectedItem).UsarItem(((Item)lbItemsOnAterrain.SelectedItem)) == true)
                {
                    mapController.eliminarDelMapaUnItemUtilizado((Item)lbItemsOnAterrain.SelectedItem, mapController.GetMap());
                    LoadListBoxOfItemsOnAcurrentTerrain();
                    LoadProgressbarOfSelectedEntity();
                }


            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                LoadProgressbarOfSelectedEntity();
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (mapController.CheckIfAnyEntityDiedAfterTheAttack(((Entity)lbEntitiesOnAterrain.SelectedItem), (Entity)lbEntitiesToAttack.SelectedItem))
            {
                LoadListBoxOfEntitiesOnAcurrentTerrain();
                LoadListboxOfEntitiesToAttack();
            }
            LoadProgressbarOfSelectedEntity();
            LoadProgressbarOfEntitiesToAttackPlayerTwo();

            //((Entity)lbEntitiesOnAterrain.SelectedItem).resolverFinalmenteElAtaque((Entity)lbEntitiesToAttack.SelectedItem);

            //}
            //catch(Exception ex)
            //{
            //new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
            //}




            /*
            try
            {
                int result = ((Entity)lbEntitiesOnAterrain.SelectedItem).BeingAttacked(((Entity)lbEntitiesOnAterrain.SelectedItem).Attack(((Entity)lbEntitiesToAttack.SelectedItem)), ((Entity)lbEntitiesToAttack.SelectedItem));
                if (result == 1)//puede ser con booleanos esto en vez de int
                {
                    //MessageBox.Show("la vida esta en 0 de la entidad player one: " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name);
                    new MessageBoxDarkMode(((Entity)lbEntitiesToAttack.SelectedItem).name + " mató a " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + "!!!", "ATENCIÓN", "Ok", Resources.ko, true);
                    mapController.eliminarDelMapaUnaEntidadqMurio((Entity)lbEntitiesOnAterrain.SelectedItem, mapController.GetMap());
                    LoadListBoxOfEntitiesOnAcurrentTerrain();
                    LoadListboxOfEntitiesToAttack();
                }
                else if (result == 2)
                {
                    //MessageBox.Show("la vida esta en 0 de la entidad player two: " + ((Entity)lbEntitiesToAttack.SelectedItem).name);
                    new MessageBoxDarkMode(((Entity)lbEntitiesOnAterrain.SelectedItem).name + " mató a " + ((Entity)lbEntitiesToAttack.SelectedItem).name + "!!!", "ATENCIÓN", "Ok", Resources.ko, true);
                    mapController.eliminarDelMapaUnaEntidadqMurio((Entity)lbEntitiesToAttack.SelectedItem, mapController.GetMap());
                    LoadListboxOfEntitiesToAttack();
                    LoadListBoxOfEntitiesOnAcurrentTerrain();
                }

                LoadProgressbarOfSelectedEntity();
                LoadProgressbarOfEntitiesToAttackPlayerTwo();

            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                LoadProgressbarOfSelectedEntity();
            }
            */
        }
        /*
        private void btnSleep_Click(object sender, EventArgs e)
        {

            ((Entity)lbEntitiesOnAterrain.SelectedItem).Sleep();

            LoadProgressbarOfSelectedEntity();

        }
        */
        #endregion


        #region Selected Index Changed

        private void cbCurrentTerrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBonderingTerrains.DataSource = mapController.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem);
            LoadListBoxOfEntitiesOnAcurrentTerrain();
            LoadListBoxOfFoodsOnAcurrentTerrain();
            LoadListBoxOfItemsOnAcurrentTerrain();
            //lbFoodsOnAterrain.DataSource = ((Terrain)cbCurrentTerrain.SelectedItem).FoodsList;
            //lbItemsOnAterrain.DataSource = ((Terrain)cbCurrentTerrain.SelectedItem).ItemsList;
            ChangeColorOfSelectedHexagonAndTheirBorderingHexagons((Terrain)cbCurrentTerrain.SelectedItem);

        }

        private void lbEnvironmentsOfAnEntity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbEntitiesOnAterrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            MessageBox.Show("NOMBRE DE ENTIDAD SELECCIONADA: " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name);
            foreach (var s in ((Entity)lbEntitiesOnAterrain.SelectedItem).environmentList)
            {
                MessageBox.Show("ambiente: " + s.ToString());
            }
            */
            //btnSleep.Text = "SLEEP (" + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + ")";
            btnMoveInfo.Text = "MOVER entidad seleccionada (" + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + ") a otro terreno";


            lbEnvironmentsOfAnEntity.DataSource = ((Entity)lbEntitiesOnAterrain.SelectedItem).environmentList;//funciona
            lbId.Text = "📛Id📛 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).id;
            lbName.Text = "🐲Name🐲 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name;
            lbDiet.Text = "🍽️Diet🍽️ = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).diet;
            lbRange.Text = "🥊Attack Range🥊 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).attackRange;
            lbKingdom.Text = "👑Kingdom👑 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).kingdom;


            LoadProgressbarOfSelectedEntity();

            LoadListboxOfEntitiesToAttack();
        }

        private void lbEntitiesToAttack_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProgressbarOfEntitiesToAttackPlayerTwo();
        }

        #endregion


        #region Movement Section

        private void Hexagon_Click_For_Movement(object sender, EventArgs e)
        {
            Terrain terrenoAnteriorSeleccionado = (Terrain)cbCurrentTerrain.SelectedItem;
            HexagonControl clickedHexagon = sender as HexagonControl;
            int index = hexagonsList.IndexOf(clickedHexagon);
            //MessageBox.Show("indice hxagono clikeado: " + index);
            ChangeColorOfSelectedHexagonToMove(mapController.GetTerrains(mapController.GetMap())[index], terrenoAnteriorSeleccionado);
        }


        private void ChangeColorOfSelectedHexagonToMove(Terrain terrainDondeSeMovera, Terrain terrenoAnteriorSeleccionado)
        {
            ResetHexagonBorderColor();
            hexagonsList[terrenoAnteriorSeleccionado.Id].BorderColor = Color.Yellow;
            hexagonsList[terrenoAnteriorSeleccionado.Id].Enabled = false;

            for (int i = 0; i < ((Terrain)cbCurrentTerrain.SelectedItem).BorderingTerrainsList.Count(); i++)
            {
                hexagonsList[terrenoAnteriorSeleccionado.BorderingTerrainsList[i].Id].BorderColor = Color.DarkOrange;
            }

            hexagonsList[terrainDondeSeMovera.Id].BorderColor = Color.DarkViolet;//este vendria a ser a donde se va a mover

            btnMove.Text = "Mover a " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + " al terreno N°" + terrainDondeSeMovera.Id;
        }


        private void ChangePanelStates(bool state)
        {
            btnMoveInfo.Visible = state;
            cbCurrentTerrain.Enabled = state;
            pnAttack.Enabled = state;
            pnEntities.Enabled = state;
            pnFoods.Enabled = state;
            pnItems.Enabled = state;
        }

        private void btnMoveInfo_Click(object sender, EventArgs e)
        {
            pnMove.Visible = true;
            lbMoveInfo.Text = "👣Haga click sobre el hexagono \ndonde quiera que se mueva \n" + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + ". Tenga en cuenta que \nsólo podrá moverse sobre los \nterrenos limítrofes👣";
            foreach (var hexagon in hexagonsList)
            {
                //MessageBox.Show(hexagon.Name);
                hexagon.Click += Hexagon_Click_For_Movement;
            }
            /*
            btnMoveInfo.Visible = false;
            cbCurrentTerrain.Enabled = false;
            pnAttack.Enabled = false;
            pnEntities.Enabled = false;
            pnFoods.Enabled = false;
            pnItems.Enabled = false;
            */
            ChangePanelStates(false);
            btnMove.Visible = true;

        }



        private int GetTheIndexOfTheSelectedHexagon()
        {
            int index = 0;
            foreach (var hexagon in hexagonsList)
            {
                if (hexagon.BorderColor == Color.DarkViolet)
                {
                    index = hexagonsList.IndexOf(hexagon);
                }
            }
            return index;
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            /*
            int index = 0;
            foreach (var hexagon in hexagonsList)
            {
                if (hexagon.BorderColor == Color.DarkViolet)
                {
                    index = hexagonsList.IndexOf(hexagon);
                }
            }
            */
            Terrain terr = ((mapController.GetMap()).TerrainsList[GetTheIndexOfTheSelectedHexagon()]);
            //MessageBox.Show("terreno seleccionado en color violeta: " + terr.ToString());
            try
            {
                if (mapController.MoverEntidadAunTerreno(((Entity)lbEntitiesOnAterrain.SelectedItem), ((Terrain)cbCurrentTerrain.SelectedItem), terr))
                {
                    pnMove.Visible = false;

                    hexagonsList[((Terrain)cbCurrentTerrain.SelectedItem).Id].Enabled = true;

                    SetHexagonClickWithBorderingTerrains();
                  
                    LoadListBoxOfEntitiesOnAcurrentTerrain();
                    btnMove.Visible = false;

                    ChangePanelStates(true);

                }
                
                /*
                if (mapController.chequearQueUnTerrenoEnParticularSeaLimitrofeDelTerrenoActualSeleccionado(((Terrain)cbCurrentTerrain.SelectedItem), terr) == true)
                {
                    if (((Entity)lbEntitiesOnAterrain.SelectedItem).MoveThrough(terr.TerrainType) == true)
                    {
                        //borrar la entidad del terreno donde se encuentra
                        mapController.eliminarUnaEntidadDeUnTerreno(((Entity)lbEntitiesOnAterrain.SelectedItem), (Terrain)cbCurrentTerrain.SelectedItem);


                        //luego agregarla a el terreno donde se va a mover
                        mapController.agregarEntidadAlTerrenoDondeSeMovio(((Entity)lbEntitiesOnAterrain.SelectedItem), terr);

                        //MessageBox.Show("se puede..");


                        pnMove.Visible = false;

                        hexagonsList[((Terrain)cbCurrentTerrain.SelectedItem).Id].Enabled = true;

                        //hayq volver a llamar al hexagon click anterior
                        SetHexagonClickWithBorderingTerrains();
                        /*
                        foreach (var hexagon in hexagonsList)
                        {
                            //MessageBox.Show(hexagon.Name);
                            hexagon.Click += Hexagon_Click;
                        }
                        

                        LoadListBoxOfEntitiesOnAcurrentTerrain();
                        btnMove.Visible = false;

                        ChangePanelStates(true);
                        /*
                        btnMoveInfo.Visible = true;

                        cbCurrentTerrain.Enabled = true;
                        pnAttack.Enabled = true;
                        pnEntities.Enabled = true;
                        pnFoods.Enabled = true;
                        pnItems.Enabled = true;
                        
                    }
                }
                */
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
            }
        }

        private void MapTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxDarkMode messageBox = new MessageBoxDarkMode("Esta seguro que desea salir?? Se cerrará la aplicación por completo...", "Aviso", "OkCancel", Resources.question);
            if (GeneralController.MessageBoxDialogResult(messageBox) == false)
            {
                e.Cancel = true;
            }
        }
    }
    #endregion
}
