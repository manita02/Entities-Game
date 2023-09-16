using crudsGame.src.controllers;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
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

namespace crudsGame.src.views
{
    public partial class CRUDitem : Form
    {
        List<IInteractuable> itemList = new List<IInteractuable>();
        ItemController itemCtn;
        public CRUDitem()
        {
            itemCtn = ItemController.getInstance();
            InitializeComponent();
            this.dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //creo q es para que las columnas se adapten al tamaño del dgv
            GeneralController.cargarTiposDeItemsEnCombo(itemList, cbType);
        }

        bool exist = false;
        int rows = 0;

        public IInteractuable GetSelectedItemFromCombobox()
        {
            foreach (var item in itemList)
            {
                if (item.ToString() == cbType.Text)
                {
                    return item;
                }
            }
            return null;
        }

        private void CheckIfItemExists(IInteractuable item)
        {
            /*
            if (itemList.Count > 0)
            {
                for (int fila = 0; fila < dgvItems.Rows.Count - 1; fila++)
                {

                    if (dgvItems.Rows[fila].Cells[2].Value.ToString() == item.Name)
                    {
                        MessageBox.Show("El item ' " + item.Name + " ' ya existe!!!");
                        exist = true;
                    }
                }
            }
            */
        }

        private bool CheckEmptyFields()
        {
            if (txtName.Text == "" || txtValue.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios!!!");
                return true;
            }
            return false;
        }

        private bool CheckRadioButtons()
        {
            if (rdbPositive.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtValue.Text = "";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields() == false)
            {

                IInteractuable item = itemCtn.CreateItem(cbType.Text, itemList.Count(), txtName.Text, Convert.ToInt16(txtValue.Text), CheckRadioButtons());



                CheckIfItemExists(item);


                if (exist == false)
                {
                    itemCtn.AddItem(item, itemList, dgvItems);
                }
                exist = false;

                txtId.Text = Convert.ToString(itemList.Count());

                CleanFields();
            }
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                this.rows = dgvItems.SelectedRows[0].Index;
                txtId.Text = dgvItems.CurrentRow.Cells[0].Value.ToString();

                txtName.Text = dgvItems.CurrentRow.Cells[1].Value.ToString();

                //MessageBox.Show("index: " + GeneralController.LookForTheIndexOfTheComboboxOfItemsThatComesFromTheDatagrid(itemList, dgvItems));

                cbType.SelectedIndex = GeneralController.LookForTheIndexOfTheComboboxOfItemsThatComesFromTheDatagrid(itemList, dgvItems);

                txtValue.Text = dgvItems.CurrentRow.Cells[4].Value.ToString();

                if (dgvItems.CurrentRow.Cells[2].Value.ToString() == "True")
                {
                    rdbPositive.Checked = true;
                }
                else
                {
                    rdbNegative.Checked = true;
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                if (CheckEmptyFields() == false)
                {
                    IInteractuable item = itemCtn.CreateItem(cbType.Text, itemList.Count(), txtName.Text, Convert.ToInt16(txtValue.Text), CheckRadioButtons());
                    this.rows = itemCtn.UpdateAnEntity(rows, dgvItems, item);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para editar un item!!");
            }
            CleanFields();
            txtId.Text = Convert.ToString(itemList.Count());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 2)
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    int r = dgvItems.SelectedRows.Count;
                    itemCtn.DeleteAnEntity(itemList, r);
                    dgvItems.Rows.RemoveAt(r);
                    txtId.Text = Convert.ToString(itemList.Count());
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
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }
    }
}
