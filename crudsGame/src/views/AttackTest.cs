using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
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

        List<IEntity> entitiesListTest = new List<IEntity>();

        public AttackTest()
        {
            InitializeComponent();
            AddCreaturesToList();
            LoadComboboxWithMainCreatures();
        }

        public void AddCreaturesToList()
        {
            IEntity e1 = new Entity(1, KingdomCreator.CreateAkingdom(1), "pipi98", DietCreator.CreateAdiet(1), EnvironmentCreator.CreateAenvironment(1), 100, 100, 100, 100, 40, 60, 1);
            IEntity e2 = new Entity(2, KingdomCreator.CreateAkingdom(2), "ladrillo78", DietCreator.CreateAdiet(2), EnvironmentCreator.CreateAenvironment(2), 100, 100, 100, 100, 50, 30, 0);
            IEntity e3 = new Entity(3, KingdomCreator.CreateAkingdom(3), "manguera99", DietCreator.CreateAdiet(3), EnvironmentCreator.CreateAenvironment(3), 100, 100, 100, 100, 60, 20, 0);


            entitiesListTest.Add(e1);
            entitiesListTest.Add(e2);
            entitiesListTest.Add(e3);
        }


        public void LoadComboboxWithMainCreatures()

        {
            cbMainCreature.Items.Clear();
            foreach (var mc in entitiesListTest)
            {
                cbMainCreature.Items.Add(mc.ShowMainCreature());
            }
        }

        public IEntity GetSelectedMainCreatureFromCombobox()
        {
            foreach (var mc in entitiesListTest)
            {
                if (mc.ShowMainCreature() == cbMainCreature.Text)
                {
                    return mc;
                }
            }
            return null;
        }

        private void UpdateProgressbar()
        {
            lbLifeJ1.Text = Convert.ToString(GetSelectedMainCreatureFromCombobox().CurrentLife) + "%";
            pbCurrentLife.Value = GetSelectedMainCreatureFromCombobox().CurrentLife;


            lbCurrentEnergyJ1.Text = Convert.ToString(GetSelectedMainCreatureFromCombobox().CurrentEnergy) + "%";
            pbCurrentEnergy.Value = GetSelectedMainCreatureFromCombobox().CurrentEnergy;
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
                if (GetSelectedMainCreatureFromCombobox().Id != dc.Id)
                {
                    cbCreaturesThatWillBeAttacked.Items.Add(dc.ShowMainCreature());
                }
                else
                {
                    cbCreaturesThatWillBeAttacked.Items.Remove(dc);
                }
            }
        }

        public IEntity GetSelectedToDefenseCreatureFromCombobox()
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
            if (GetSelectedMainCreatureFromCombobox().CurrentEnergy > 0)
            {
                if (GetSelectedToDefenseCreatureFromCombobox().CurrentLife > 0)
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

                    GetSelectedToDefenseCreatureFromCombobox().CurrentLife = GetSelectedMainCreatureFromCombobox().Attack(GetSelectedToDefenseCreatureFromCombobox(), random1, random2);

                    UpdateProgressbar();

                    if (GetSelectedToDefenseCreatureFromCombobox().CurrentLife > 0)
                    {
                        MessageBox.Show("La vida que le quedo a la criatura a la que se ataco es de: " + GetSelectedToDefenseCreatureFromCombobox().CurrentLife);
                    }
                    else
                    {
                        MessageBox.Show("La critura atacada '" + GetSelectedToDefenseCreatureFromCombobox().Name + "' ha fallecido...");
                    }
                }
                else
                {
                    MessageBox.Show("La critura a la que se desea atacar ( '" + GetSelectedToDefenseCreatureFromCombobox().Name + "' ) ya falleció...");
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
            lbCurrentEnergyJ2.Text = "Current Energy of J2: " + GetSelectedToDefenseCreatureFromCombobox().CurrentEnergy.ToString();
            lbCurrentLifeJ2.Text = "Current Life of J2: " + GetSelectedToDefenseCreatureFromCombobox().CurrentLife.ToString();
        }

        private void cbCriatureToDefense_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJ2Labels();
        }

        //queda emprolijar los metodos y ver en q clases ubicarlos
    }
}
