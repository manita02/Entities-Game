using crudsGame.src.controllers;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Diets;
using crudsGame.src.model.Items;
using crudsGame.src.model.Kingdoms;
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

namespace crudsGame.src.views
{
    public partial class AttackTest : Form
    {


        //List<Food> foodsList = new List<Food>();
        ItemController itemCtn;
        EntityController entityCtn;
        FoodController foodCtn;


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
            txtEnvironment.Text = GetOnePlayerCreatureSelectedFromCombo().environment.ToString();
            txtKingdom.Text = GetOnePlayerCreatureSelectedFromCombo().kingdom.ToString();
            txtMaxEnergy.Text = GetOnePlayerCreatureSelectedFromCombo().maxEnergy.ToString();
            txtMaxLife.Text = GetOnePlayerCreatureSelectedFromCombo().maxLife.ToString();
            txtId.Text = GetOnePlayerCreatureSelectedFromCombo().id.ToString();
            txtDiet.Text = GetOnePlayerCreatureSelectedFromCombo().diet.ToString();
            LoadComboWithCreaturesPlayerTwo();
        }


        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (GetOnePlayerCreatureSelectedFromCombo().currentLife <= 0)
            {
                entityCtn.GetEntitiesList().Remove(GetOnePlayerCreatureSelectedFromCombo());
                LoadComboboxWithCreaturesPlayerOne();
                cbCreaturesPlayerOne.Text = "he is dead :(";
                btnAttack.Enabled = false;
                cbCreaturesPlayerTwo.Enabled = false;
            }
            else
            {
                if (GetTwoPlayerCreatureSelectedFromCombo().currentLife <= 0)
                {
                    entityCtn.GetEntitiesList().Remove(GetTwoPlayerCreatureSelectedFromCombo());
                    LoadComboWithCreaturesPlayerTwo();
                    LoadComboboxWithCreaturesPlayerOne();
                    cbCreaturesPlayerTwo.Text = "he is dead :(";
                    btnAttack.Enabled = false;
                }
                else
                {
                    GetOnePlayerCreatureSelectedFromCombo().BeingAttacked(GetOnePlayerCreatureSelectedFromCombo().Attack(GetTwoPlayerCreatureSelectedFromCombo()), GetTwoPlayerCreatureSelectedFromCombo());
                    UpdateProgressbar();
                    UpdateJ2Labels();
                }
            }
        }

        private void cbCriatureToDefense_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJ2Labels();
            btnAttack.Enabled = true;
        }

        private void btnComer_Click(object sender, EventArgs e)
        {
            GetOnePlayerCreatureSelectedFromCombo().Eat(GetOnePlayerCreatureSelectedFromCombo(), GetSelectedFoodFromCombobox());
            UpdateProgressbar();
        }

        private void btnInteract_Click(object sender, EventArgs e)
        {
            GetOnePlayerCreatureSelectedFromCombo().UsarItem(GetOnePlayerCreatureSelectedFromCombo(), GetSelectedItemFromCombobox());
            //GetSelectedItemFromCombobox().Interact(GetOnePlayerCreatureSelectedFromCombo());
            UpdateProgressbar();
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            GetOnePlayerCreatureSelectedFromCombo().Sleep();
            UpdateProgressbar();
        }
    }
}
