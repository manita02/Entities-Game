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
using static crudsGame.src.views.Design.MaterialUI;
using MaterialSkin.Controls;
using crudsGame.Properties;
using crudsGame.src.controllers;
using crudsGame.src.model.Map.Terrains;
using crudsGame.src.model;
using crudsGame.src.model.Items;
using crudsGame.src.interfaces;
using crudsGame.src.model.Foods;
using crudsGame.src.model.Map;
using MessageBox = crudsGame.src.model.MessageBox;

namespace crudsGame.src.views
{
    public partial class MapTest : MaterialForm
    {
        List<HexagonControl> hexagonsList = new List<HexagonControl>();
        MapController mapCtn = MapController.GetInstance();

        public MapTest()
        {
            InitializeComponent();
            LoadMaterial(this);
            AddHexagonsToList();
            SetHexagonClickWithBorderingTerrains();
            AddNumbersToHexagons();
            LoadMap();
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
        }


        private void SetHexagonClickWithBorderingTerrains()
        {
            foreach (var hexagon in hexagonsList)
            {
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
                cbCurrentTerrain.SelectedIndex = index;
                ChangeColorOfSelectedHexagonAndTheirBorderingHexagons(mapCtn.GetTerrains(mapCtn.GetMap())[index]);
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
            for (int i = 0; i < terrain.BorderingTerrainsList.Count(); i++)
            {
                hexagonsList[terrain.BorderingTerrainsList[i].Id].BorderColor = Color.DarkOrange; // Terrenos limitrofes del seleccionado anteriormente
            }
        }

        private void LoadMap()
        {
            if (mapCtn.GenerateMap() == true)
            {
                cbCurrentTerrain.DataSource = mapCtn.GetTerrains(mapCtn.GetMap());
                lbBonderingTerrains.DataSource = mapCtn.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem);
                PaintHexagons();
            }
        }


        private void PaintHexagons()
        {
            List<Terrain> terrainsList = mapCtn.GetTerrains(mapCtn.GetMap());
            for (int i = 0; i < hexagonsList.Count(); i++)
            {
                hexagonsList[i].BackColor = terrainsList[i].TerrainType.GetColor();
            }
        }



        #region Load Listboxs

        private void SelectFirstListboxIndex(ListBox listbox)
        {
            if (listbox.Items.Count > 0)
            {
                listbox.SelectedIndex = 0;
            }

        }
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
            }
            else if (((Entity)lbEntitiesOnAterrain.SelectedItem).attackRange == 0)
            {
                /// <summary>
                /// Llama a este metodo y le pasa la lista de entidades que tiene el terreno actual
                /// </summary>
                AddEntitiesToListbox(((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList, lbEntitiesToAttack); //entidades en terreno actual
            }
            lbEntitiesToAttack.Items.Remove((Entity)lbEntitiesOnAterrain.SelectedItem);//elimina el seleccionado
            SelectFirstListboxIndex(lbEntitiesToAttack);
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
            SelectFirstListboxIndex(lbEntitiesOnAterrain);
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

        private void btnEat_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Entity)lbEntitiesOnAterrain.SelectedItem).Eat(((Food)lbFoodsOnAterrain.SelectedItem)) == true)
                {
                    mapCtn.RemoveAnEatenFoodFromTheMap((Food)lbFoodsOnAterrain.SelectedItem);
                    LoadListBoxOfFoodsOnAcurrentTerrain();
                    LoadProgressbarOfSelectedEntity();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", "Ok", Resources.warning);
                LoadProgressbarOfSelectedEntity();
            }

        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (((Entity)lbEntitiesOnAterrain.SelectedItem).UseItem(((Item)lbItemsOnAterrain.SelectedItem)))
            {
                mapCtn.RemoveAusedItemFromTheMap((Item)lbItemsOnAterrain.SelectedItem);
                LoadListBoxOfItemsOnAcurrentTerrain();
                LoadProgressbarOfSelectedEntity();
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if(mapCtn.CheckIfAnyEntityDiedAfterTheAttack(((Entity)lbEntitiesOnAterrain.SelectedItem), ((Entity)lbEntitiesToAttack.SelectedItem)))
            {
                LoadListBoxOfEntitiesOnAcurrentTerrain();
                LoadListboxOfEntitiesToAttack();

            }
            LoadProgressbarOfSelectedEntity();
            LoadProgressbarOfEntitiesToAttackPlayerTwo();
        }
        #endregion


        #region Selected Index Changed

        private void cbCurrentTerrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBonderingTerrains.DataSource = mapCtn.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem);
            LoadListBoxOfEntitiesOnAcurrentTerrain();
            LoadListBoxOfFoodsOnAcurrentTerrain();
            LoadListBoxOfItemsOnAcurrentTerrain();
            ChangeColorOfSelectedHexagonAndTheirBorderingHexagons((Terrain)cbCurrentTerrain.SelectedItem);
        }

        private void CheckIfTheSelectedEntityHasEnergy()
        {
            if (((Entity)lbEntitiesOnAterrain.SelectedItem).currentEnergy == 0)
            {
                MessageBox.Show("La entidad seleccionada actualmente (" + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + ") NO tiene energía, por lo tanto NO podrá realizar ningún tipo de interacción!!", "ATENCIÓN", "Ok", Resources.loseEnergy);
                btnAttack.Enabled = false;
                btnEat.Enabled = false;
                btnUse.Enabled = false;
                btnMoveInfo.Enabled = false;
            }
            else
            {
                btnAttack.Enabled = true;
                btnEat.Enabled = true;
                btnUse.Enabled = true;
                btnMoveInfo.Enabled = true;
            }
        }

        private void lbEntitiesOnAterrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMoveInfo.Text = "MOVER entidad seleccionada (" + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + ") a otro terreno";

            lbEnvironmentsOfAnEntity.DataSource = ((Entity)lbEntitiesOnAterrain.SelectedItem).environmentList;//funciona
            lbId.Text = "📛Id📛 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).id;
            lbName.Text = "🐲Name🐲 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name;
            lbDiet.Text = "🍽️Diet🍽️ = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).diet;
            lbRange.Text = "🥊Attack Range🥊 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).attackRange;
            lbKingdom.Text = "👑Kingdom👑 = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).kingdom;

            LoadProgressbarOfSelectedEntity();
            LoadListboxOfEntitiesToAttack();

            CheckIfTheSelectedEntityHasEnergy();
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
            ChangeColorOfSelectedHexagonToMove(mapCtn.GetTerrains(mapCtn.GetMap())[index], terrenoAnteriorSeleccionado);
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
                hexagon.Click += Hexagon_Click_For_Movement;
            }
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
            Terrain terr = ((mapCtn.GetMap()).TerrainsList[GetTheIndexOfTheSelectedHexagon()]);
            try
            {
                if (mapCtn.MoveEntitiyToTerrain(((Entity)lbEntitiesOnAterrain.SelectedItem), ((Terrain)cbCurrentTerrain.SelectedItem), terr))
                {
                    pnMove.Visible = false;
                    hexagonsList[((Terrain)cbCurrentTerrain.SelectedItem).Id].Enabled = true;
                    SetHexagonClickWithBorderingTerrains();
                    LoadListBoxOfEntitiesOnAcurrentTerrain();
                    btnMove.Visible = false;
                    ChangePanelStates(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", "Ok", Resources.warning);
            }
        }

        private void MapTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxDarkMode messageBox = MessageBox.Show("Esta seguro que desea salir?? Se cerrará la aplicación por completo...", "Aviso", "OkCancel", Resources.question);
            if (model.MessageBox.MessageBoxDialogResult(messageBox) == false)
            {
                e.Cancel = true;
            }
        }
    }
    #endregion
}
