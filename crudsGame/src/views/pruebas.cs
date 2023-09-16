using crudsGame.src.controllers;
using crudsGame.src.controllers.ItemsCtn;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
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
    public partial class pruebas : Form
    {
        PositiveItemController positiveItemCtn;
        NegativeItemController negativeItemCtn;

        List<IInteractuable> itemList = new List<IInteractuable>();
        public pruebas()
        {
            positiveItemCtn = PositiveItemController.getInstance();
            negativeItemCtn = NegativeItemController.getInstance();
            InitializeComponent();
            this.dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ReadOnly = true;
            rdbPositive.Checked = true;


        }
        int rows = 0;
        bool existe = false;


        /*
        private void CheckIfItemExists(IInteractuable item)
        {
            if (itemList.Count > 0)
            {
                for (int fila = 0; fila < dgvItems.Rows.Count - 1; fila++)
                {

                    if (dgvItems.Rows[fila].Cells[1].Value.ToString() == item.GetItemName())
                    {
                        MessageBox.Show("El item ' " + item.GetItemName() + " ' ya existe!!!");
                        existe = true;
                    }
                }
            }
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
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            if (rdbPositive.Checked)
            {
                if (CheckEmptyFields() == false)
                {

                    IInteractuable item = GeneralController.CreateItem(
                    rdbPositive.Text,
                    Convert.ToInt16(itemList.Count()),
                    Convert.ToString(txtName.Text),
                    Convert.ToInt16(txtValue.Text));



                    CheckIfItemExists(item);

                    if (existe == false)
                    {
                        positiveItemCtn.AddPositiveItem(item, itemList, dgvItems);
                    }
                    existe = false;

                }

            }
            else
            {
                if (CheckEmptyFields() == false)
                {
                    IInteractuable item = GeneralController.CreateItem(
                     rdbNegative.Text,
                     Convert.ToInt16(itemList.Count()),
                     Convert.ToString(txtName.Text),
                     Convert.ToInt16(txtValue.Text));

                    CheckIfItemExists(item);
                    if (existe == false)
                    {
                        negativeItemCtn.AddNegativeItem(item, itemList, dgvItems);
                    }
                    existe = false;
                }



            }
            txtId.Text = Convert.ToString(itemList.Count());
            limpiar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvItems.SelectedRows.Count > 0)
            {
                if (rdbPositive.Checked)
                {
                    if (CheckEmptyFields() == false)
                    {
                        IInteractuable item = GeneralController.CreateItem(
                        rdbPositive.Text,
                        Convert.ToInt16(Convert.ToInt16(txtId.Text)),
                        Convert.ToString(txtName.Text),
                        Convert.ToInt16(txtValue.Text));
                        this.rows = positiveItemCtn.editando(rows, dgvItems, item); //funca
                    }


                }
                else
                {
                    if (CheckEmptyFields() == false)
                    {
                        IInteractuable item = GeneralController.CreateItem(rdbNegative.Text,
                        Convert.ToInt16(Convert.ToInt16(txtId.Text)),
                        Convert.ToString(txtName.Text),
                        Convert.ToInt16(txtValue.Text));
                        this.rows = negativeItemCtn.editandoNegativos(rows, dgvItems, item);
                    }


                }
                txtId.Text = Convert.ToString(itemList.Count());

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para editar un item!!");
            }
            limpiar();
        }

        private void limpiar()
        {
            txtName.Text = "";
            txtValue.Text = "";
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e) //al seleccionar fila se cargan los datos en los textbox
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                this.rows = dgvItems.SelectedRows[0].Index;
                txtId.Text = dgvItems.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvItems.CurrentRow.Cells[1].Value.ToString();
                txtValue.Text = dgvItems.CurrentRow.Cells[2].Value.ToString();
                if (dgvItems.CurrentRow.Cells[3].Value.ToString() == "Positive (+ energy)")
                {
                    rdbPositive.Checked = true;
                }
                else
                {
                    rdbNegative.Checked = true;
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 2)
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    int r = dgvItems.SelectedRows.Count;

                    for (int i = 0; i < itemList.Count; i++)
                    {
                        if (i == r)
                        {
                            itemList.RemoveAt(i);
                        }
                    }
                    dgvItems.Rows.RemoveAt(r);
                    txtId.Text = Convert.ToString(itemList.Count());
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la tabla para eliminar un item!!");
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
    
     */   
     }
}
