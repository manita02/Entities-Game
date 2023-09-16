using crudsGame.src.controllers;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Kingdoms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace crudsGame.src.views
{
    public partial class CRUDentity : Form
    {
        List<IKingdom> kingdomList = new List<IKingdom>();
        List<IEnvironment> environmentList = new List<IEnvironment>();
        List<IDiet> dietList = new List<IDiet>();
        List<IEntity> entityList = new List<IEntity>();


        EntityController entityCtn;
        public CRUDentity()
        {
            entityCtn = EntityController.getInstance();
            InitializeComponent();
            this.dgvEntities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //creo q es para que las columnas se adapten al tamaño del dgv
            GeneralController.cargarDietasEnCombo(dietList, cbDiet);
            GeneralController.cargarReinosEnCombo(kingdomList, cbKingdom);
            GeneralController.cargarAmbientesEnCombo(environmentList, cbEnvironment);

        }

        bool exist = false;
        int rows = 0;

        public IDiet GetSelectedDietFromCombobox()
        {
            foreach (var diet in dietList)
            {
                if (diet.ToString() == cbDiet.Text)
                {
                    return diet;
                }
            }
            return null;
        }

        public IEnvironment GetSelectedEnvironmentFromCombobox()
        {
            foreach (var env in environmentList)
            {
                if (env.ToString() == cbEnvironment.Text)
                {
                    return env;
                }
            }
            return null;
        }

        public IKingdom GetSelectedKingdomFromCombobox()
        {
            foreach (var kin in kingdomList)
            {
                if (kin.ToString() == cbKingdom.Text)
                {
                    return kin;
                }
            }
            return null;
        }

        private void CheckIfEntityExists(IEntity entity)
        {
            if (entityList.Count > 0)
            {
                for (int fila = 0; fila < dgvEntities.Rows.Count - 1; fila++)
                {

                    if (dgvEntities.Rows[fila].Cells[2].Value.ToString() == entity.Name)
                    {
                        MessageBox.Show("La criatura ' " + entity.Name + " ' ya existe!!!");
                        exist = true;
                    }
                }
            }
        }

        private bool CheckEmptyFields()
        {
            if (txtName.Text == "" || txtDefense.Text == "" || txtRange.Text == "" || txtAttack.Text == "" || txtMaxEnergy.Text == "" || txtCurrentEnergy.Text == "" || txtMaxLife.Text == "" || txtCurrentLife.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios!!!");
                return true;
            }
            return false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields() == false)
            {

                IEntity entity = entityCtn.CreateEntity(entityList.Count(), GetSelectedKingdomFromCombobox(), txtName.Text, GetSelectedDietFromCombobox(), GetSelectedEnvironmentFromCombobox(), Convert.ToInt16(txtMaxEnergy.Text), Convert.ToInt16(txtMaxLife.Text), Convert.ToInt16(txtAttack.Text), Convert.ToInt16(txtDefense.Text), Convert.ToInt16(txtRange.Text));

                CheckIfEntityExists(entity);

                if (exist == false)
                {
                    entityCtn.AddEntity(entity, entityList, dgvEntities);
                }
                exist = false;

                txtId.Text = Convert.ToString(entityList.Count());

                CleanFields();
            }

        }


        private void dgvEntities_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedRows.Count > 0)
            {
                this.rows = dgvEntities.SelectedRows[0].Index;
                txtId.Text = dgvEntities.CurrentRow.Cells[0].Value.ToString();
                cbKingdom.SelectedIndex = GeneralController.LookForTheIndexOfTheComboboxOfKingdomsThatComesFromTheDatagrid(kingdomList, dgvEntities);
                txtName.Text = dgvEntities.CurrentRow.Cells[2].Value.ToString();
                cbDiet.SelectedIndex = GeneralController.LookForTheIndexOfTheComboboxOfDietsThatComesFromTheDatagrid(dietList, dgvEntities);
                cbEnvironment.SelectedIndex = GeneralController.LookForTheIndexOfTheComboboxOfEnvironmentsThatComesFromTheDatagrid(environmentList, dgvEntities);
                txtAttack.Text = dgvEntities.CurrentRow.Cells[5].Value.ToString();
                txtDefense.Text = dgvEntities.CurrentRow.Cells[6].Value.ToString();
                txtRange.Text = dgvEntities.CurrentRow.Cells[7].Value.ToString();
                txtMaxEnergy.Text = dgvEntities.CurrentRow.Cells[8].Value.ToString();
                txtCurrentEnergy.Text = dgvEntities.CurrentRow.Cells[9].Value.ToString();
                txtMaxLife.Text = dgvEntities.CurrentRow.Cells[10].Value.ToString();
                txtCurrentLife.Text = dgvEntities.CurrentRow.Cells[11].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedRows.Count > 0)
            {
                if (CheckEmptyFields() == false)
                {
                    IEntity entity = entityCtn.CreateEntity(Convert.ToInt16(txtId.Text), GetSelectedKingdomFromCombobox(), txtName.Text, GetSelectedDietFromCombobox(), GetSelectedEnvironmentFromCombobox(), Convert.ToInt16(txtMaxEnergy.Text), Convert.ToInt16(txtMaxLife.Text), Convert.ToInt16(txtAttack.Text), Convert.ToInt16(txtDefense.Text), Convert.ToInt16(txtRange.Text));
                    this.rows = entityCtn.UpdateAnEntity(rows, dgvEntities, entity);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para editar una entidad!!");
            }
            CleanFields();
            txtId.Text = Convert.ToString(entityList.Count());



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEntities.Rows.Count > 2)
            {
                if (dgvEntities.SelectedRows.Count > 0)
                {
                    int r = dgvEntities.SelectedRows.Count;
                    entityCtn.DeleteAnEntity(entityList, r);
                    dgvEntities.Rows.RemoveAt(r);
                    txtId.Text = Convert.ToString(entityList.Count());
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la tabla para editar una entidad!!");
                }
            }
            else
            {
                MessageBox.Show("Debe existir mas de una entidad en la tabla para poder eliminar!!");
            }
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtRange.Text = "";
            txtAttack.Text = "";
            txtDefense.Text = "";
            cbKingdom.SelectedIndex = 0;
            cbEnvironment.SelectedIndex = 0;
            cbDiet.SelectedIndex = 0;
        }

        private void txtAttack_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void txtDefense_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void txtRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void txtMaxEnergy_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void txtCurrentEnergy_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void txtMaxLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void txtCurrentLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void cbKingdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKingdom.Text == "Alien")
            {

                //BackColor = Color.MediumSeaGreen;
                picCreature.Image = Properties.Resources.alien;
            }
            if (cbKingdom.Text == "Animalia")
            {
                //BackColor = Color.Peru;
                picCreature.Image = Properties.Resources.animalia;
            }
            if (cbKingdom.Text == "Plantae")
            {
                //BackColor = Color.Peru;
                picCreature.Image = Properties.Resources.plant;
            }
            if (cbKingdom.Text == "Machine")
            {
                //BackColor = Color.Peru;
                picCreature.Image = Properties.Resources.robot;
            }
        }
    }
}
