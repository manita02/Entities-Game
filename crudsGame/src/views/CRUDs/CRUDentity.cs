using crudsGame.src.controllers;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Kingdoms;
using System;
using System.Collections;
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
using static crudsGame.src.views.Design.MaterialUI;
using MaterialSkin.Controls;
using crudsGame.Properties;
using MessageBox = crudsGame.src.model.MessageBox;

namespace crudsGame.src.views
{
    public partial class CRUDentity : MaterialForm
    {

        EntityController entityCtn;
        public CRUDentity()
        {
            entityCtn = EntityController.getInstance();
            InitializeComponent();
            LoadMaterial(this);
            LoadCreaturesbByDefault();
            this.dgvEntities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            cbDiet.DataSource = entityCtn.GetDietList();
            cbKingdom.DataSource = entityCtn.GetKingdomList();
            clbEnvironments.DataSource = entityCtn.GetEnvironmentList();
        }
        int rows = 0;

        private void UpdateEntityId()
        {
            txtId.Text = Convert.ToString(entityCtn.GetEntitiesList().Count());
        }

        private void LoadCreaturesbByDefault()
        {
            foreach (var criature in entityCtn.GetEntitiesList())
            {
                LoadCreatureIntoDatagrid(dgvEntities.Rows.Add(), criature);
            }
        }

        private void LoadCreatureIntoDatagrid(int x, Entity entity)
        {
            dgvEntities.Rows[x].Cells[0].Value = entity.id;
            dgvEntities.Rows[x].Cells[1].Value = entity.kingdom;
            dgvEntities.Rows[x].Cells[2].Value = entity.name;
            dgvEntities.Rows[x].Cells[3].Value = entity.diet;
            DeselectChecksFromTheListbox();
            CheckEnvironmentsInListbox(entity);
            dgvEntities.Rows[x].Cells[5].Value = entity.attackPoints;
            dgvEntities.Rows[x].Cells[6].Value = entity.defensePoints;
            dgvEntities.Rows[x].Cells[7].Value = entity.attackRange;
            dgvEntities.Rows[x].Cells[8].Value = entity.maxEnergy;
            dgvEntities.Rows[x].Cells[9].Value = entity.currentEnergy;
            dgvEntities.Rows[x].Cells[10].Value = entity.maxLife;
            dgvEntities.Rows[x].Cells[11].Value = entity.currentLife;
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


        #region Selected Index Changed
        private void dgvEntities_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedRows.Count > 0)
            {
                this.rows = dgvEntities.SelectedRows[0].Index;
                txtId.Text = dgvEntities.CurrentRow.Cells[0].Value.ToString();
                cbKingdom.SelectedIndex = GetIndexOfKingdomsComboThatComesFromTheDatagrid();
                txtName.Text = dgvEntities.CurrentRow.Cells[2].Value.ToString();
                cbDiet.SelectedIndex = GetIndexOfDietComboThatComesFromTheDatagrid();
                DeselectChecksFromTheListbox();
                CheckEnvironmentsInListbox(entityCtn.SearchEntityById((int)(dgvEntities.CurrentRow.Cells[0].Value)));
                txtAttack.Text = dgvEntities.CurrentRow.Cells[5].Value.ToString();
                txtDefense.Text = dgvEntities.CurrentRow.Cells[6].Value.ToString();
                txtRange.Text = dgvEntities.CurrentRow.Cells[7].Value.ToString();
                txtMaxEnergy.Text = dgvEntities.CurrentRow.Cells[8].Value.ToString();
                txtMaxLife.Text = dgvEntities.CurrentRow.Cells[10].Value.ToString();
            }
        }

        private void cbKingdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbKingdom.Text)
            {
                case "Alien":
                    picCreature.Image = Properties.Resources.alien;
                    break;
                case "Animalia":
                    picCreature.Image = Properties.Resources.animalia;
                    break;
                case "Plantae":
                    picCreature.Image = Properties.Resources.plant;
                    break;
                case "Machine":
                    picCreature.Image = Properties.Resources.robot;
                    break;
            }
        }


        #endregion


        #region CheckedListboxEnvironments Section
        private void CheckEnvironmentsInListbox(Entity entity)
        {
            for (int i = 0; i < clbEnvironments.Items.Count; i++)
            {
                if (entityCtn.VerifyIfTheItemListboxEnvironmentIsInTheListOfEnvironmentsItself(entity, (IEnvironment)clbEnvironments.Items[i]) == true)
                {
                    clbEnvironments.SetItemChecked(i, true);
                }
            }
        }

        private List<IEnvironment> GetListOfCheckedEnvironments()
        {
            List<IEnvironment> list = new List<IEnvironment>();
            for (int i = 0; i <= (clbEnvironments.Items.Count - 1); i++)
            {
                if (clbEnvironments.GetItemChecked(i))
                {
                    //MessageBox.Show("los chequedos son:: " + checkLbEnvironments.Items[i].ToString());
                    list.Add((IEnvironment)clbEnvironments.Items[i]);
                }
            }
            return list;

        }

        private void DeselectChecksFromTheListbox()
        {
            for (int i = 0; i < clbEnvironments.Items.Count; i++)
            {
                clbEnvironments.SetItemChecked(i, false);
            }
        }



        #endregion


        #region Buttons Interactions
        private void btnCreatee_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckMaximumNumberToEnterInDefenseAndAttackPoints() == true)
                {
                    Entity entity = entityCtn.CreateEntity(entityCtn.GetEntitiesList().Count(), (IKingdom)(cbKingdom.SelectedItem), txtName.Text, (IDiet)(cbDiet.SelectedItem), GetListOfCheckedEnvironments(), GeneralController.CheckThatTheFieldIsNotNull(txtMaxEnergy), GeneralController.CheckThatTheFieldIsNotNull(txtMaxLife), GeneralController.CheckThatTheFieldIsNotNull(txtAttack), GeneralController.CheckThatTheFieldIsNotNull(txtDefense), Convert.ToInt16(txtRange.Text));
                    
                    if (entityCtn.CheckIfAnEntityCreatedWithTheSameNameAlreadyExists(entity) == false)
                    {
                        entityCtn.AddEntity(entity);
                        MessageBox.Show("Entidad (" + entity.name + ") creada satisfactoriamente!!", "Aviso", "Ok", Resources.check);
                        LoadCreatureIntoDatagrid(dgvEntities.Rows.Add(), entity);                                                             
                    }
                    UpdateEntityId();
                    CleanFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " por esto no se creará la entidad", "Error", "Ok", Resources.error);
            }
        }


        private void btnUpdatee_Click(object sender, EventArgs e)
        {
            if (CheckMaximumNumberToEnterInDefenseAndAttackPoints() == true)
            {
                MessageBoxDarkMode messageBox = new MessageBoxDarkMode("Esta seguro de guardar los cambios??", "ALERTA", "OkCancel", Resources.warning);
                if (model.MessageBox.MessageBoxDialogResult(messageBox) == true)
                {
                    try
                    {
                        if (dgvEntities.SelectedRows.Count > 0)
                        {
                            Entity entity = entityCtn.Update(entityCtn.SearchEntityById((int)dgvEntities.CurrentRow.Cells[0].Value), Convert.ToInt32(txtId.Text), (IKingdom)(cbKingdom.SelectedItem), txtName.Text, (IDiet)(cbDiet.SelectedItem), GetListOfCheckedEnvironments(), GeneralController.CheckThatTheFieldIsNotNull(txtMaxEnergy), GeneralController.CheckThatTheFieldIsNotNull(txtMaxLife), GeneralController.CheckThatTheFieldIsNotNull(txtAttack), GeneralController.CheckThatTheFieldIsNotNull(txtDefense), Convert.ToInt16(txtRange.Text));
                            LoadCreatureIntoDatagrid(rows, entity);
                            this.rows = 0;
                            btnCreatee.Visible = true;
                            btnDeletee.Visible = true;
                            dgvEntities.Enabled = true;
                            MessageBox.Show("Entidad actualizada con éxito!!", "Aviso", "Ok", Resources.update);
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar una fila de la tabla para editar una entidad!!", "Error", "Ok", Resources.error);
                        }
                        CleanFields();
                        UpdateEntityId();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " por esto no se editará la entidad", "Error", "Ok", Resources.error);
                        btnCreatee.Visible = false;
                        btnDeletee.Visible = false;
                        dgvEntities.Enabled = false;
                    }

                }

            }
        }

        private void btnDeletee_Click(object sender, EventArgs e)
        {
            MessageBoxDarkMode messageBox = new MessageBoxDarkMode("Esta seguro de eliminar esta entidad??", "ALERTA", "OkCancel", Resources.warning);
            if (model.MessageBox.MessageBoxDialogResult(messageBox) == true)
            {
                if (dgvEntities.SelectedRows.Count > 0)
                {
                    int row = dgvEntities.CurrentRow.Index;
                    entityCtn.DeleteAnEntity(row);
                    dgvEntities.Rows.RemoveAt(row);
                    UpdateEntityId();
                    MessageBox.Show("Entidad eliminada con éxito!!", "Aviso", "Ok", Resources.delete);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la tabla para eliminar una entidad!!", "Error", "Ok", Resources.error);
                }
                UpdateEntityId();
            }
        }

        #endregion


        private bool CheckMaximumNumberToEnterInDefenseAndAttackPoints()
        {
            if (Convert.ToInt16(txtAttack.Text) > 400 || Convert.ToInt16(txtAttack.Text) > 400)
            {
                MessageBox.Show("Los puntos de ataque y defensa de una entidad, deben ser menores a 400", "Error", "Ok", Resources.error);
                return false;
            }
            return true;
        }


        private void txtAttack_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtRange.Text = "";
            txtAttack.Text = "";
            txtDefense.Text = "";
            cbKingdom.SelectedIndex = 0;
            cbDiet.SelectedIndex = 0;
        }
    }
}
