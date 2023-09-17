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

        List<Entity> entitiesListTest = new List<Entity>();
        List<Food> fooodss = new List<Food>();
        MassiveItemCreator entityCtn;
        //entityCtn = MassiveItemCreator.getInstance();

        public AttackTest()
        {
            InitializeComponent();
            AddCreaturesToList();
            LoadComboboxWithMainCreatures();
            entityCtn = MassiveItemCreator.getInstance();
            comboBox1.DataSource = entityCtn.CreateItemsMassively();

            Food f1 = new Food(1, "carne", 10, new Carnivore());
            Food f2 = new Food(2, "manzana", 20, new Carnivore());
            Food f3 = new Food(3, "grillo", 30, new SolarEnergy());
            
            fooodss.Add(f1);
            fooodss.Add(f2);
            fooodss.Add(f3);

            LoadcBfOODS();
        }

        public void AddCreaturesToList()
        {
            Entity e1 = new Entity(1, KingdomCreator.CreateAkingdom(1), "pipi98", DietCreator.CreateAdiet(4), EnvironmentCreator.CreateAenvironment(1),45, 88, 45, 56, 40, 60, 1);
            Entity e2 = new Entity(2, KingdomCreator.CreateAkingdom(2), "ladrillo78", DietCreator.CreateAdiet(2), EnvironmentCreator.CreateAenvironment(2), 12, 23, 66, 100, 50, 30, 0);
            Entity e3 = new Entity(3, KingdomCreator.CreateAkingdom(3), "manguera99", DietCreator.CreateAdiet(3), EnvironmentCreator.CreateAenvironment(3), 34, 55, 77, 100, 60, 20, 0);


            entitiesListTest.Add(e1);
            MessageBox.Show("energy: " + e1.currentEnergy);
            entitiesListTest.Add(e2);
            entitiesListTest.Add(e3);
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
            foreach (var mc in entitiesListTest)
            {
                cbMainCreature.Items.Add(mc.ShowMainCreature());
            }
        }

        public Entity GetSelectedMainCreatureFromCombobox()
        {
            foreach (var mc in entitiesListTest)
            {
                //MessageBox.Show("nombre en combo: " + cbMainCreature.Text);
                
                if (mc.ShowMainCreature() == cbMainCreature.Text)
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
        }

        private void cbMainCreature_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressbar();

            LoadComboboxWithCreaturesThatWillBeAttacked();

            cbMainCreature.Enabled = false;
        }

        public void LoadComboboxWithCreaturesThatWillBeAttacked()
        {
            cbCreaturesThatWillBeAttacked.Items.Clear();
            int id = 0;

            foreach (var dc in entitiesListTest)
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
                    cbCreaturesThatWillBeAttacked.Items.Add(dc.ShowMainCreature());
                }
                else
                {
                    cbCreaturesThatWillBeAttacked.Items.Remove(dc);
                }
            }
        }

        public Entity GetSelectedToDefenseCreatureFromCombobox()
        {
            foreach (var dc in entitiesListTest)
            {
                if (dc.ShowMainCreature() == cbCreaturesThatWillBeAttacked.Text)
                {
                    return dc;
                }
            }
            return null;
        }
        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (GetSelectedMainCreatureFromCombobox().currentEnergy > 0)
            {
                if (GetSelectedToDefenseCreatureFromCombobox().currentLife > 0)
                {
                    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 }; //dado
                    Random rnd = new Random();
                    int randIndex = rnd.Next(numbers.Count);
                    int random1 = numbers[randIndex];
                    MessageBox.Show("Jugador 1 ha sacado: " + random1 + " esto se sumara a los puntos de ataque de la criatura atacante..");

                    Random rnd2 = new Random();
                    randIndex = rnd2.Next(numbers.Count);
                    int random2 = numbers[randIndex];
                    MessageBox.Show("Jugador 2 ha tirado tambien el dado y saco: " + random2 + " esto se sumara a los puntos de defensa a la criatura a la que se le inflige daño..");

                    GetSelectedToDefenseCreatureFromCombobox().currentLife = GetSelectedMainCreatureFromCombobox().Attack(GetSelectedToDefenseCreatureFromCombobox(), random1, random2);

                    UpdateProgressbar();

                    if (GetSelectedToDefenseCreatureFromCombobox().currentLife > 0)
                    {
                        MessageBox.Show("La vida que le quedo a la criatura a la que se ataco es de: " + GetSelectedToDefenseCreatureFromCombobox().currentLife);
                    }
                    else
                    {
                        MessageBox.Show("La critura atacada '" + GetSelectedToDefenseCreatureFromCombobox().name + "' ha fallecido...");
                    }
                }
                else
                {
                    MessageBox.Show("La critura a la que se desea atacar ( '" + GetSelectedToDefenseCreatureFromCombobox().name + "' ) ya falleció...");
                }

                //Console.WriteLine(random);
            }
            else
            {
                MessageBox.Show("Esta critura esta cansada y no tiene suficiente energía, por lo tanto no podra realizar el ataque");
            }
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

        //queda emprolijar los metodos y ver en q clases ubicarlos
    }
}
