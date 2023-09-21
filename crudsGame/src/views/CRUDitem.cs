using crudsGame.src.controllers;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
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

namespace crudsGame.src.views
{
    public partial class CRUDitem : Form
    {
        ItemController itemCtn;
        public CRUDitem()
        {
            itemCtn = ItemController.getInstance();
            InitializeComponent();
            LoadItemsByDefault();
            this.dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbType.DataSource = itemCtn.GetStrategyItemsList();
            cbKingdom.DataSource = itemCtn.GetKingdomList();
        }

        bool exist = false;
        int rows = 0;

        private void LoadItemsByDefault()
        {
            foreach (var item in itemCtn.GetItemList())
            {
                LoadItemIntoDatagrid(dgvItems.Rows.Add(), item);
            }
        }

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

        private bool CheckEmptyFields()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("El campo nombre NO puede esar vacío!!!");
                return true;
            }
            return false;
        }

        private void CleanFields()
        {
            txtName.Text = "";
        }

        private void UpdateItemId()
        {
            txtId.Text = Convert.ToString(itemCtn.GetItemList().Count());
        }

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

        private void LoadItemIntoDatagrid(int x, Item item)
        {
            dgvItems.Rows[x].Cells[0].Value = item.id;
            dgvItems.Rows[x].Cells[1].Value = item.name;
            dgvItems.Rows[x].Cells[2].Value = item.kingdom;
            dgvItems.Rows[x].Cells[3].Value = item.itemStrategy;
        }

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

        #region Buttons Interactions
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields() == false)
            {
                Item item = itemCtn.CreateItem(itemCtn.GetItemList().Count(), txtName.Text, (IStrategyTypeOfItem)(cbType.SelectedItem), (IKingdom)(cbKingdom.SelectedItem));
                CheckIfItemExists(item);
                if (exist == false)
                {
                    itemCtn.GetItemList().Add(item);
                    LoadItemIntoDatagrid(dgvItems.Rows.Add(), item);
                }
                exist = false;

                UpdateItemId();

                CleanFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                if (CheckEmptyFields() == false)
                {
                    Item item = itemCtn.CreateItem(itemCtn.GetItemList().Count(), txtName.Text, (IStrategyTypeOfItem)(cbType.SelectedItem), (IKingdom)(cbKingdom.SelectedItem));
                    //this.rows = itemCtn.UpdateAnEntity(rows, dgvItems, item);
                    LoadItemIntoDatagrid(rows, item);
                    this.rows = 0;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para editar un item!!");
            }
            CleanFields();
            UpdateItemId();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 2)
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    int r = dgvItems.CurrentRow.Index;
                    itemCtn.GetItemList().RemoveAt(r);
                    dgvItems.Rows.RemoveAt(r);
                    UpdateItemId();
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
        #endregion

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }
    }
}
