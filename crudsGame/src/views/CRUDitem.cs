using crudsGame.src.controllers;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Diets;
using crudsGame.src.model.Items;
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
using Item = crudsGame.src.model.Items.Item;
using static crudsGame.src.views.MaterialUI;
using MaterialSkin.Controls;
using crudsGame.Properties;

namespace crudsGame.src.views
{
    public partial class CRUDitem : MaterialForm
    {
        ItemController itemCtn;
        public CRUDitem()
        {
            itemCtn = ItemController.getInstance();
            InitializeComponent();
            LoadMaterial(this);
            LoadItemsByDefault();
            this.dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbType.DataSource = itemCtn.GetStrategyItemsList();
            cbKingdom.DataSource = itemCtn.GetKingdomList();
        }
        int rows = 0;

        private void UpdateItemId()
        {
            txtId.Text = Convert.ToString(itemCtn.GetItemList().Count());
        }

        private void LoadItemIntoDatagrid(int x, Item item)
        {
            dgvItems.Rows[x].Cells[0].Value = item.id;
            dgvItems.Rows[x].Cells[1].Value = item.name;
            dgvItems.Rows[x].Cells[2].Value = item.kingdom;
            dgvItems.Rows[x].Cells[3].Value = item.itemStrategy;
        }

        private void LoadItemsByDefault()
        {
            foreach (var item in itemCtn.GetItemList())
            {
                LoadItemIntoDatagrid(dgvItems.Rows.Add(), item);
            }
        }

        /*
        private void CheckIfItemExists(Item item)
        {

            if (itemCtn.GetItemList().Count > 0)
            {
                for (int fila = 0; fila < dgvItems.Rows.Count - 1; fila++)
                {

                    if (dgvItems.Rows[fila].Cells[1].Value.ToString() == item.name)
                    {
                        MessageBox.Show("El item ' " + item.name + " ' ya existe!!!");
                        exist = true;
                    }
                }
            }

        }
        */

        #region Get Kingdoms and Item Types that comes from the Datagrid
        public int GetIndexOfKingdomsComboThatComesFromTheDatagrid()
        {
            foreach (var kin in itemCtn.GetKingdomList())
            {
                if (kin.ToString() == dgvItems.CurrentRow.Cells[2].Value.ToString())
                {
                    return itemCtn.GetKingdomList().IndexOf(kin);
                }
            }
            return -1;
        }

        public int GetIndexOfTheTypeItemsComboThatComesFromTheDatagrid()
        {
            foreach (var strategy in itemCtn.GetStrategyItemsList())
            {
                if (strategy.ToString() == dgvItems.CurrentRow.Cells[3].Value.ToString())
                {
                    return itemCtn.GetStrategyItemsList().IndexOf(strategy);
                }
            }
            return -1;

        }
        #endregion


        #region Select Index Changed


        /*
        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                this.rows = dgvItems.SelectedRows[0].Index;
                txtId.Text = dgvItems.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvItems.CurrentRow.Cells[1].Value.ToString();
                cbType.SelectedIndex = GetIndexOfTheTypeItemsComboThatComesFromTheDatagrid();
                cbKingdom.SelectedIndex = GetIndexOfKingdomsComboThatComesFromTheDatagrid();
            }
        }
        */

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbType.Text)
            {
                case "Increases Energy":
                    picItem.Image = Properties.Resources.moreEnergy;
                    break;
                case "Increases Life":
                    picItem.Image = Properties.Resources.moreLife;
                    break;
                case "Increases Attack Points":
                    picItem.Image = Properties.Resources.moreAttack;
                    break;
                case "Increases Defense Points":
                    picItem.Image = Properties.Resources.moreDefense;
                    break;
                case "Loses Energy":
                    picItem.Image = Properties.Resources.loseEnergy;
                    break;
                case "Loses Attack Points":
                    picItem.Image = Properties.Resources.loseAttack;
                    break;
                case "Loses Life":
                    picItem.Image = Properties.Resources.loseLifee;
                    break;
                case "Loses Defense Points":
                    picItem.Image = Properties.Resources.loseDefense;
                    break;
            }
        }

        private void dgvItems_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                this.rows = dgvItems.SelectedRows[0].Index;
                txtId.Text = dgvItems.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvItems.CurrentRow.Cells[1].Value.ToString();
                cbType.SelectedIndex = GetIndexOfTheTypeItemsComboThatComesFromTheDatagrid();
                cbKingdom.SelectedIndex = GetIndexOfKingdomsComboThatComesFromTheDatagrid();
            }
        }

        #endregion




        #region Buttons Interactions
        private void btnCreatee_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = itemCtn.CreateItem(itemCtn.GetItemList().Count(), txtName.Text, (IStrategyTypeOfItem)(cbType.SelectedItem), (IKingdom)(cbKingdom.SelectedItem));
                if (itemCtn.CheckIfAitemCreatedWithTheSameNameAlreadyExists(item) == false)
                {
                    itemCtn.AddItem(item);
                    //itemCtn.GetItemList().Add(item);
                    new MessageBoxDarkMode("Ítem ("+item.name+") creado satisfactoriamente!!", "Aviso", "Ok", Resources.check, true);
                    LoadItemIntoDatagrid(dgvItems.Rows.Add(), item);
                }
                /*
                CheckIfItemExists(item);
                if (exist == false)
                {
                    
                }
                exist = false;
                */

                UpdateItemId();

                CleanFields();
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message + " por esto no se creará el item", "Error", "Ok", Resources.error, true);
            }



        }

        private void btnUpdatee_Click(object sender, EventArgs e)
        {
            MessageBoxDarkMode messageBox = new MessageBoxDarkMode("Esta seguro de guardar los cambios??", "ALERTA", "OkCancel", Resources.warning);
            if (GeneralController.MessageBoxDialogResult(messageBox) == true)
            {
                try
                {
                    if (dgvItems.SelectedRows.Count > 0)
                    {
                        Item item = itemCtn.Update(itemCtn.SearchItemById((int)dgvItems.CurrentRow.Cells[0].Value), Convert.ToInt32(txtId.Text), txtName.Text, (IStrategyTypeOfItem)(cbType.SelectedItem), (IKingdom)(cbKingdom.SelectedItem));
                        //Item item = itemCtn.CreateItem(itemCtn.GetItemList().Count(), txtName.Text, (IStrategyTypeOfItem)(cbType.SelectedItem), (IKingdom)(cbKingdom.SelectedItem));
                        //this.rows = itemCtn.UpdateAnEntity(rows, dgvItems, item);
                        LoadItemIntoDatagrid(rows, item);
                        this.rows = 0;
                        btnCreatee.Visible = true;
                        btnDeletee.Visible = true;
                        dgvItems.Enabled = true;
                        new MessageBoxDarkMode("Item actualizado con éxito!!", "Aviso", "Ok", Resources.update, true);

                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una fila de la tabla para editar un item!!");
                    }
                    CleanFields();
                    UpdateItemId();


                }
                catch (Exception ex)
                {
                    new MessageBoxDarkMode(ex.Message + " por esto no se editará el item", "Error", "Ok", Resources.error, true);
                    btnCreatee.Visible = false;
                    btnDeletee.Visible = false;
                    dgvItems.Enabled = false;
                }
            }

        }

        private void btnDeletee_Click(object sender, EventArgs e)
        {
            MessageBoxDarkMode messageBox = new MessageBoxDarkMode("Esta seguro de eliminar este item??", "ALERTA", "OkCancel", Resources.warning);
            if (GeneralController.MessageBoxDialogResult(messageBox) == true)
            {
                if (dgvItems.Rows.Count > 2)
                {
                    if (dgvItems.SelectedRows.Count > 0)
                    {
                        int row = dgvItems.CurrentRow.Index;
                        //itemCtn.GetItemList().RemoveAt(row);
                        itemCtn.DeleteAitem(row);
                        dgvItems.Rows.RemoveAt(row);
                        UpdateItemId();
                        new MessageBoxDarkMode("Item eliminado con éxito!!", "Aviso", "Ok", Resources.delete, true);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una fila de la tabla para editar un item!!");
                    }
                }
                else
                {
                    MessageBox.Show("Debe existir mas de un item en la tabla para poder eliminar!!");
                }
                UpdateItemId();
            }
        }
        #endregion

        private void CleanFields()
        {
            txtName.Text = "";
        }
    }
}
