using crudsGame.src.controllers;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Diets;
using crudsGame.src.model.Items;
using crudsGame.src.model.Items.Strategy;
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

        //List<Entity> entitiesListTest = new List<Entity>();
        List<Food> fooodss = new List<Food>();
        MassiveItemCreator entityCtn;
        MassiveCreatorEntities massiveCreatorEntities;
        //entityCtn = MassiveItemCreator.getInstance();

        public AttackTest()
        {
            InitializeComponent();
            //AddCreaturesToList();
            //LoadComboboxWithMainCreatures();
            entityCtn = MassiveItemCreator.getInstance();
            massiveCreatorEntities = MassiveCreatorEntities.getInstance();
            comboBox1.DataSource = entityCtn.CreateItemsMassively();
            cbMainCreature.DataSource = massiveCreatorEntities.CreateEntitiesMassively();
            cbMainCreature.SelectedIndex = 0;
            cbCreaturesThatWillBeAttacked.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            

            Food f1 = new Food(1, "carne", 10, new Carnivore());
            Food f2 = new Food(2, "manzana", 20, new Carnivore());
            Food f3 = new Food(3, "grillo", 30, new SolarEnergy());

            

            fooodss.Add(f1);
            fooodss.Add(f2);
            fooodss.Add(f3);

            LoadcBfOODS();
            comboBox2.SelectedIndex = 0;
        }

        public void AddCreaturesToList()
        {

            //int id, IKingdom kingdom, string name, IDiet diet, IEnvironment environment, int maxenergy, int currentenergy, int maxlife, int currentlife, int attackpoints, int defensepoints, int attackrange

            Entity e1 = new Entity(1, KingdomCreator.CreateAkingdom(1), "po", DietCreator.CreateAdiet(4), EnvironmentCreator.CreateAenvironment(1), 100, 100, 40, 60, 1);
            Entity e2 = new Entity(2, KingdomCreator.CreateAkingdom(2), "tigresa", DietCreator.CreateAdiet(2), EnvironmentCreator.CreateAenvironment(2), 100, 100, 50, 30, 0);
            Entity e3 = new Entity(3, KingdomCreator.CreateAkingdom(3), "paladini", DietCreator.CreateAdiet(3), EnvironmentCreator.CreateAenvironment(3), 100, 100, 60, 20, 0);

            /*
            entitiesListTest.Add(e1);
            MessageBox.Show("energy: " + e1.currentEnergy);
            entitiesListTest.Add(e2);
            entitiesListTest.Add(e3); 
            */
        }
        public void LoadcBfOODS()

        {
            comboBox2.Items.Clear();
            foreach (var mc in fooodss)
            {
                comboBox2.Items.Add(mc.ToString());
            }
        }

        public void LoadComboboxWithMainCreatures()

        {
            cbMainCreature.Items.Clear();
            foreach (var mc in massiveCreatorEntities.GetEntitiesList())
            {
                cbMainCreature.Items.Add(mc.ToString());
            }
        }

        public Entity GetSelectedMainCreatureFromCombobox()
        {
            foreach (var mc in massiveCreatorEntities.GetEntitiesList())
            {
                //MessageBox.Show("nombre en combo: " + cbMainCreature.Text);

                if (mc.ToString() == cbMainCreature.Text)
                {
                    return mc;
                }
            }
            return null;
        }

        private void UpdateProgressbar()
        {
            
            lbLifeJ1.Text = Convert.ToString(GetSelectedMainCreatureFromCombobox().currentLife) + "%";
            pbCurrentLife.Value = GetSelectedMainCreatureFromCombobox().currentLife;


            lbCurrentEnergyJ1.Text = Convert.ToString(GetSelectedMainCreatureFromCombobox().currentEnergy) + "%";
            pbCurrentEnergy.Value = GetSelectedMainCreatureFromCombobox().currentEnergy; //establecer propiedades

            txtAttack.Text = GetSelectedMainCreatureFromCombobox().attackPoints.ToString();

            txtDefense.Text = GetSelectedMainCreatureFromCombobox().defensePoints.ToString();

            txtEnvironment.Text = GetSelectedMainCreatureFromCombobox().environment.ToString();

            txtKingdom.Text = GetSelectedMainCreatureFromCombobox().kingdom.ToString();

            txtMaxEnergy.Text = GetSelectedMainCreatureFromCombobox().maxEnergy.ToString();

            txtMaxlLIFE.Text = GetSelectedMainCreatureFromCombobox().maxLife.ToString();

            txtId.Text = GetSelectedMainCreatureFromCombobox().id.ToString();

            txtDiet.Text = GetSelectedMainCreatureFromCombobox().diet.ToString();

        }

        private void cbMainCreature_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressbar();

            LoadComboboxWithCreaturesThatWillBeAttacked();

            //cbMainCreature.Enabled = false;
        }

        public void LoadComboboxWithCreaturesThatWillBeAttacked()
        {
            cbCreaturesThatWillBeAttacked.Items.Clear();
            int id = 0;

            foreach (var dc in massiveCreatorEntities.GetEntitiesList())
            {
                /*
                if(get_selected_MAINCREATURE_from_combobox().AttackRange > 0) //esta comparacion esta mal xq cualquier criatura puede estar en el mismo terreno o en uno limitrofe... la comparacion tendria que estar al momento de atacar
                {
                    cbCriatureToDefense.Items.Add(dc.mostrarParaMainCreature()); //esto fue.. hasta q no se tenga el terreno no hacer nada --> hay q subdividir la lista y poner algunos en posicion actual y otros en limitrofes
                }
                else
                {
                    if(dc.AttackRange == 0)
                    {
                        cbCriatureToDefense.Items.Add(dc.mostrarParaMainCreature());
                    }
                }
                */
                if (GetSelectedMainCreatureFromCombobox().id != dc.id)
                {
                    cbCreaturesThatWillBeAttacked.Items.Add(dc.ToString());
                }
                else
                {
                    cbCreaturesThatWillBeAttacked.Items.Remove(dc);
                }
            }
        }

        public Entity GetSelectedToDefenseCreatureFromCombobox()
        {
            foreach (var dc in massiveCreatorEntities.GetEntitiesList())
            {
                if (dc.ToString() == cbCreaturesThatWillBeAttacked.Text)
                {
                    return dc;
                }
            }
            return null;
        }
        private void btnAttack_Click(object sender, EventArgs e)
        {
            
            GetSelectedMainCreatureFromCombobox().BeingAttacked(GetSelectedMainCreatureFromCombobox().Attack(GetSelectedToDefenseCreatureFromCombobox()), GetSelectedToDefenseCreatureFromCombobox());
            UpdateProgressbar();
            UpdateJ2Labels();
            
            
        }


        private void UpdateJ2Labels()
        {
            lbCurrentEnergyJ2.Text = "Current Energy of J2: " + GetSelectedToDefenseCreatureFromCombobox().currentEnergy.ToString();
            lbCurrentLifeJ2.Text = "Current Life of J2: " + GetSelectedToDefenseCreatureFromCombobox().currentLife.ToString();
        }

        private void cbCriatureToDefense_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJ2Labels();
        }

        public Food GetSelectedFoodFromCombobox()
        {
            foreach (var food in fooodss)
            {
                if (food.ToString() == comboBox2.Text)
                {
                    return food;
                }
            }
            return null;
        }


        private void btnComer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("dieta entidad: " + GetSelectedMainCreatureFromCombobox().diet);
            //MessageBox.Show("dieta comida: " + GetSelectedFoodFromCombobox().diet);
            GetSelectedMainCreatureFromCombobox().Eat(GetSelectedMainCreatureFromCombobox(), GetSelectedFoodFromCombobox());
            UpdateProgressbar();
        }


        public Item GetSelectedItemFromCombobox()
        {
            foreach (var item in entityCtn.getLista())
            {
                if (item.ToString() == comboBox1.Text)
                {
                    return item;
                }
            }
            return null;
        }

        private void btnInteract_Click(object sender, EventArgs e)
        {
            GetSelectedItemFromCombobox().Interact(GetSelectedMainCreatureFromCombobox());
            UpdateProgressbar();
            txtAttack.Text = GetSelectedMainCreatureFromCombobox().attackPoints.ToString();

            txtDefense.Text = GetSelectedMainCreatureFromCombobox().defensePoints.ToString();

        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            GetSelectedMainCreatureFromCombobox().Sleep();
            UpdateProgressbar();
        }

        //queda emprolijar los metodos y ver en q clases ubicarlos
    }
}
