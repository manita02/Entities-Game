using crudsGame.Properties;
using crudsGame.src.controllers;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Foods.Diets;
using crudsGame.src.model.Foods;
using crudsGame.src.model.Items;
using crudsGame.src.model.Kingdoms;
using crudsGame.src.model.Map;
using crudsGame.src.model.Map.Terrains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace crudsGame.src.views
{
    public partial class AttackTest : Form
    {


        //List<Food> foodsList = new List<Food>();
        ItemController itemCtn;
        EntityController entityCtn;
        FoodController foodCtn;
        MapController mapCtn = MapController.GetInstance();
        //TerrainController terrainCtn = TerrainController.GetInstance();


        public AttackTest()
        {
            InitializeComponent();


            itemCtn = ItemController.getInstance();
            entityCtn = EntityController.getInstance();
            foodCtn = FoodController.getInstance();
            LoadComboboxWithCreaturesPlayerOne();
            cbItems.DataSource = itemCtn.GetItemList();
            cbFoods.DataSource = foodCtn.GetFoodList();

            //LoadComboWithFoods();


            cbCreaturesPlayerOne.SelectedIndex = 0;
            cbCreaturesPlayerTwo.SelectedIndex = 0;
            cbItems.SelectedIndex = 0;

            RefreshMap();
            /*
            Food f1 = new Food(1, "carne", 10, new Carnivore());
            Food f2 = new Food(2, "manzana", 20, new Carnivore());
            Food f3 = new Food(3, "grillo", 30, new SolarEnergy());
            
            


            foodsList.Add(f1);
            foodsList.Add(f2);
            foodsList.Add(f3);
            */



            cbFoods.SelectedIndex = 0;
        }

        #region Load Comboboxs 
        public void LoadComboWithFoods()
        {
            cbFoods.Items.Clear();
            foreach (var food in foodCtn.GetFoodList())
            {
                cbFoods.Items.Add(food);
            }
        }

        public void LoadComboboxWithCreaturesPlayerOne()
        {
            cbCreaturesPlayerOne.Items.Clear();
            foreach (var creatures in entityCtn.GetEntitiesList())
            {
                cbCreaturesPlayerOne.Items.Add(creatures);
            }
        }

        public void LoadComboWithCreaturesPlayerTwo()
        {
            cbCreaturesPlayerTwo.Items.Clear();
            foreach (var creature in entityCtn.GetEntitiesList())
            {
                if (GetOnePlayerCreatureSelectedFromCombo().id != creature.id)
                {
                    cbCreaturesPlayerTwo.Items.Add(creature);
                }
                else
                {
                    cbCreaturesPlayerTwo.Items.Remove(creature);
                }
            }
            cbCreaturesPlayerTwo.SelectedIndex = 0;
        }

        #endregion


        #region Get food, items, creatures from player one and two selected from the combobox
        public Entity GetOnePlayerCreatureSelectedFromCombo()
        {

            return ((Entity)(cbCreaturesPlayerOne.SelectedItem));
            /*
            foreach (var creature in massiveCreatorEntities.GetEntitiesList())
            {
                //MessageBox.Show("nombre en combo: " + cbMainCreature.Text);

                if (creature.ToString() == cbCreaturesPlayerOne.Text)
                {
                    return creature;
                }
            }
            
            return null;
            */
        }

        public Entity GetTwoPlayerCreatureSelectedFromCombo()
        {
            return ((Entity)(cbCreaturesPlayerTwo.SelectedItem));
            /*
            foreach (var dc in massiveCreatorEntities.GetEntitiesList())
            {
                if (dc.ToString() == cbCreaturesPlayerTwo.Text)
                {
                    return dc;
                }
            }
            return null;
            */
        }

        public Food GetSelectedFoodFromCombobox()
        {
            return ((Food)(cbFoods.SelectedItem));
            /*
            foreach (var food in foodsList)
            {
                if (food.ToString() == cbFoods.Text)
                {
                    return food;
                }
            }
            return null;
            */
        }

        public Item GetSelectedItemFromCombobox()
        {
            return ((Item)(cbItems.SelectedItem));
            /*
            foreach (var item in entityCtn.getLista())
            {
                if (item.ToString() == comboBox1.Text)
                {
                    return item;
                }
            }
            return null;
            */
        }

        # endregion 

        private void UpdateProgressbar()
        {

            lbLifeJ1.Text = Convert.ToString(GetOnePlayerCreatureSelectedFromCombo().currentLife) + "%";
            pbCurrentLife.Value = GetOnePlayerCreatureSelectedFromCombo().currentLife;


            lbCurrentEnergyJ1.Text = Convert.ToString(GetOnePlayerCreatureSelectedFromCombo().currentEnergy) + "%";
            pbCurrentEnergy.Value = GetOnePlayerCreatureSelectedFromCombo().currentEnergy;

            txtAttack.Text = GetOnePlayerCreatureSelectedFromCombo().attackPoints.ToString();

            txtDefense.Text = GetOnePlayerCreatureSelectedFromCombo().defensePoints.ToString();


        }

        private void UpdateJ2Labels()
        {
            lbCurrentEnergyJ2.Text = "Current Energy of J2: " + GetTwoPlayerCreatureSelectedFromCombo().currentEnergy.ToString();
            lbCurrentLifeJ2.Text = "Current Life of J2: " + GetTwoPlayerCreatureSelectedFromCombo().currentLife.ToString();
        }

        private void cbMainCreature_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAttack.Enabled = true;
            cbCreaturesPlayerTwo.Enabled = true;
            UpdateProgressbar();
            txtAttack.Text = GetOnePlayerCreatureSelectedFromCombo().attackPoints.ToString();
            txtDefense.Text = GetOnePlayerCreatureSelectedFromCombo().defensePoints.ToString();
            //txtEnvironment.Text = GetOnePlayerCreatureSelectedFromCombo().environment.ToString();
            txtKingdom.Text = GetOnePlayerCreatureSelectedFromCombo().kingdom.ToString();
            txtMaxEnergy.Text = GetOnePlayerCreatureSelectedFromCombo().maxEnergy.ToString();
            txtMaxLife.Text = GetOnePlayerCreatureSelectedFromCombo().maxLife.ToString();
            txtId.Text = GetOnePlayerCreatureSelectedFromCombo().id.ToString();
            txtDiet.Text = GetOnePlayerCreatureSelectedFromCombo().diet.ToString();
            LoadComboWithCreaturesPlayerTwo();
        }


        private void btnAttack_Click(object sender, EventArgs e)
        {
            /*
            int result = GetOnePlayerCreatureSelectedFromCombo().BeingAttacked(GetOnePlayerCreatureSelectedFromCombo().Attack(GetTwoPlayerCreatureSelectedFromCombo()), GetTwoPlayerCreatureSelectedFromCombo());
            //MessageBox.Show("valor de result: " + result.ToString());
            if (result == 1)
            {
                MessageBox.Show(" " + GetOnePlayerCreatureSelectedFromCombo().name + " falleció!!");
                entityCtn.GetEntitiesList().Remove(GetOnePlayerCreatureSelectedFromCombo());
                LoadComboboxWithCreaturesPlayerOne();
                //cbCreaturesPlayerOne.Text = "he is dead :(";
                //btnAttack.Enabled = false;
                //cbCreaturesPlayerTwo.Enabled = false;
                cbCreaturesPlayerOne.SelectedIndex = 0;
            }
            else
            {
                if (result == 2)
                {
                    //MessageBox.Show(" " + GetTwoPlayerCreatureSelectedFromCombo().name + " falleció!!");
                    entityCtn.GetEntitiesList().Remove(GetTwoPlayerCreatureSelectedFromCombo());
                    LoadComboWithCreaturesPlayerTwo();
                    LoadComboboxWithCreaturesPlayerOne();
                    //cbCreaturesPlayerTwo.Text = "he is dead :(";
                    //btnAttack.Enabled = false;
                    cbCreaturesPlayerOne.SelectedIndex = 0;
                }
            }
            UpdateProgressbar();
            UpdateJ2Labels()*/
        }

        private void cbCriatureToDefense_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJ2Labels();
            btnAttack.Enabled = true;
        }

        private void btnComer_Click(object sender, EventArgs e)
        {
            try
            {
                GetOnePlayerCreatureSelectedFromCombo().Eat(GetSelectedFoodFromCombobox());
                UpdateProgressbar();
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message + " por eso no puede comer", "ALERTA", "Ok", Resources.warning, true);
            }
            
        }

        private void btnInteract_Click(object sender, EventArgs e)
        {
            //GetOnePlayerCreatureSelectedFromCombo().currentEnergy = 0;
            //try
            //{
            
                if (GetOnePlayerCreatureSelectedFromCombo().currentLife <= 0)
                {
                System.Windows.Forms.MessageBox.Show("Su entidad ha perdido toda su vida por lo tanto murió...");
                    entityCtn.GetEntitiesList().Remove(GetOnePlayerCreatureSelectedFromCombo());
                    LoadComboboxWithCreaturesPlayerOne();
                    cbCreaturesPlayerOne.SelectedIndex = 0;
                }
                else
                {
                    GetOnePlayerCreatureSelectedFromCombo().UsarItem(GetSelectedItemFromCombobox());
                }
            UpdateProgressbar();

            /*
            if (GetOnePlayerCreatureSelectedFromCombo().UsarItem(GetOnePlayerCreatureSelectedFromCombo(), GetSelectedItemFromCombobox()) == false)
            {
                //MessageBox.Show("Su entidad ha perdido toda su vida por lo tanto murió...");
                entityCtn.GetEntitiesList().Remove(GetOnePlayerCreatureSelectedFromCombo());
                LoadComboboxWithCreaturesPlayerOne();
                cbCreaturesPlayerOne.SelectedIndex = 0;
                //cbCreaturesPlayerOne.Items.Remove(GetOnePlayerCreatureSelectedFromCombo());
            }
            UpdateProgressbar();
            */

            //}
            //catch (Exception ex)
            //{
            //new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
            //UpdateProgressbar();
            //}


        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            GetOnePlayerCreatureSelectedFromCombo().Sleep();
            UpdateProgressbar();
        }

        private void RefreshMap()
        {
            //bindingTerrains.DataSource = terrainCtn.GetTerrainList(); //cheq estooooooooooooo
            bindingTerrains.ResetBindings(false);
            cbCurrentTerrain.DataSource = bindingTerrains;
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            mapCtn.GenerateMap();
            //cbCurrentTerrain.DataSource = terrainCtn.GetTerrainList();
            //RefreshMap();
            btnMap.Enabled = false;
        }

        private void cbCurrentTerrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbBorderingTerrainsOfCurrentTerrain.Items.Clear();
            if (cbCurrentTerrain.SelectedItem is Terrain terrain)
            {
                //cbBorderingTerrainsOfCurrentTerrain.DataSource = terrainCtn.GetBorderingTerrainsList(terrain);

                //bindingBonderingTerrains.DataSource = terrainCtn.GetBorderingTerrainsList(terrain);
                bindingBonderingTerrains.ResetBindings(false);
                cbBorderingTerrainsOfCurrentTerrain.DataSource = bindingBonderingTerrains;
                listBox1.DataSource = bindingBonderingTerrains;


            }
        }
    }
}
