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

        EntityController entityCtn;
        public CRUDentity()
        {
            entityCtn = EntityController.getInstance();
            InitializeComponent();
            LoadCreaturesbByDefault();
            this.dgvEntities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //es para que las columnas se adapten al tamaño del dgv
            cbDiet.DataSource = entityCtn.GetDietList();
            cbEnvironment.DataSource = entityCtn.GetEnvironmentList();
            cbKingdom.DataSource = entityCtn.GetKingdomList();
            checkLbEnvironments.DataSource = entityCtn.GetEnvironmentList();
        }

        bool exist = false;
        int rows = 0;

        private void LoadCreaturesbByDefault()
        {
            foreach (var criature in entityCtn.GetEntitiesList())
            {
                LoadCreatureIntoDatagrid(dgvEntities.Rows.Add(), criature);
            }
        }

        #region Search in combobox the kingdoms, environments and diets that come from the datagrid
        public int GetIndexOfKingdomsComboThatComesFromTheDatagrid()
        {
            foreach (var kin in entityCtn.GetKingdomList())
            {
                if (kin.ToString() == dgvEntities.CurrentRow.Cells[1].Value.ToString())
                {
                    return entityCtn.GetKingdomList().IndexOf(kin);
                }
            }
            return -1;
        }


        public int GetIndexOfDietComboThatComesFromTheDatagrid()
        {
            foreach (var diet in entityCtn.GetDietList())
            {
                if (diet.ToString() == dgvEntities.CurrentRow.Cells[3].Value.ToString())
                {
                    return entityCtn.GetDietList().IndexOf(diet);
                }
            }
            return -1;
        }


        public int GetIndexOfEnvironmentsComboThatComesFromTheDatagrid()
        {
            foreach (var env in entityCtn.GetEnvironmentList())
            {
                if (env.ToString() == dgvEntities.CurrentRow.Cells[4].Value.ToString())
                {
                    return entityCtn.GetEnvironmentList().IndexOf(env);
                }
            }
            return -1;
        }

        #endregion

        private void CheckIfEntityExists(Entity entity)
        {
            if (entityCtn.GetEntitiesList().Count > 0)
            {
                for (int fila = 0; fila < dgvEntities.Rows.Count - 1; fila++)
                {

                    if (dgvEntities.Rows[fila].Cells[2].Value.ToString() == entity.name)
                    {
                        MessageBox.Show("La criatura ' " + entity.name + " ' ya existe!!!");
                        exist = true;
                    }
                }
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

        private bool CheckEmptyFields()
        {
            if (txtName.Text == "" || txtDefense.Text == "" || txtRange.Text == "" || txtAttack.Text == "" || txtMaxEnergy.Text == "" || txtMaxLife.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios!!!");
                return true;
            }
            return false;
        }


        private void UpdateEntityId()
        {
            txtId.Text = Convert.ToString(entityCtn.GetEntitiesList().Count());
        }


        private void LoadCreatureIntoDatagrid(int x, Entity entity)
        {
            dgvEntities.Rows[x].Cells[0].Value = entity.id;
            dgvEntities.Rows[x].Cells[1].Value = entity.kingdom;
            dgvEntities.Rows[x].Cells[2].Value = entity.name;
            dgvEntities.Rows[x].Cells[3].Value = entity.diet;
            dgvEntities.Rows[x].Cells[4].Value = entity.environment;
            dgvEntities.Rows[x].Cells[5].Value = entity.attackPoints;
            dgvEntities.Rows[x].Cells[6].Value = entity.defensePoints;
            dgvEntities.Rows[x].Cells[7].Value = entity.attackRange;
            dgvEntities.Rows[x].Cells[8].Value = entity.maxEnergy;
            dgvEntities.Rows[x].Cells[9].Value = entity.currentEnergy;
            dgvEntities.Rows[x].Cells[10].Value = entity.maxLife;
            dgvEntities.Rows[x].Cells[11].Value = entity.currentLife;
        }

        private void dgvEntities_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedRows.Count > 0)
            {
                this.rows = dgvEntities.SelectedRows[0].Index;
                txtId.Text = dgvEntities.CurrentRow.Cells[0].Value.ToString();
                cbKingdom.SelectedIndex = GetIndexOfKingdomsComboThatComesFromTheDatagrid();
                txtName.Text = dgvEntities.CurrentRow.Cells[2].Value.ToString();
                cbDiet.SelectedIndex = GetIndexOfDietComboThatComesFromTheDatagrid();
                cbEnvironment.SelectedIndex = GetIndexOfEnvironmentsComboThatComesFromTheDatagrid();
                txtAttack.Text = dgvEntities.CurrentRow.Cells[5].Value.ToString();
                txtDefense.Text = dgvEntities.CurrentRow.Cells[6].Value.ToString();
                txtRange.Text = dgvEntities.CurrentRow.Cells[7].Value.ToString();
                txtMaxEnergy.Text = dgvEntities.CurrentRow.Cells[8].Value.ToString();
                txtMaxLife.Text = dgvEntities.CurrentRow.Cells[10].Value.ToString();
            }
        }

        #region button interactions
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields() == false)
            {
                Entity entity = entityCtn.CreateEntity(entityCtn.GetEntitiesList().Count(), (IKingdom)(cbKingdom.SelectedItem), txtName.Text, (IDiet)(cbDiet.SelectedItem), (IEnvironment)(cbEnvironment.SelectedItem), Convert.ToInt16(txtMaxEnergy.Text), Convert.ToInt16(txtMaxLife.Text), Convert.ToInt16(txtAttack.Text), Convert.ToInt16(txtDefense.Text), Convert.ToInt16(txtRange.Text));
                CheckIfEntityExists(entity);
                if (exist == false)
                {
                    entityCtn.GetEntitiesList().Add(entity); //se carga en la lista
                    LoadCreatureIntoDatagrid(dgvEntities.Rows.Add(), entity); //se carga en la tabla
                }
                exist = false;
                UpdateEntityId();
                CleanFields();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedRows.Count > 0)
            {
                if (CheckEmptyFields() == false)
                {
                    Entity entity = entityCtn.CreateEntity(entityCtn.GetEntitiesList().Count(), (IKingdom)(cbKingdom.SelectedItem), txtName.Text, (IDiet)(cbDiet.SelectedItem), (IEnvironment)(cbEnvironment.SelectedItem), Convert.ToInt16(txtMaxEnergy.Text), Convert.ToInt16(txtMaxLife.Text), Convert.ToInt16(txtAttack.Text), Convert.ToInt16(txtDefense.Text), Convert.ToInt16(txtRange.Text));
                    //this.rows = entityCtn.UpdateAnEntity(rows, dgvEntities, entity);
                    LoadCreatureIntoDatagrid(rows, entity);
                    this.rows = 0;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para editar una entidad!!");
            }
            CleanFields();
            UpdateEntityId();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEntities.Rows.Count > 2)
            {
                if (dgvEntities.SelectedRows.Count > 0)
                {
                    //int r = dgvEntities.SelectedRows.Count;
                    int r = dgvEntities.CurrentRow.Index;
                    //entityCtn.DeleteAnEntity(r);
                    entityCtn.GetEntitiesList().RemoveAt(r);
                    dgvEntities.Rows.RemoveAt(r);
                    UpdateEntityId();
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
            UpdateEntityId();
        }
        #endregion

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
