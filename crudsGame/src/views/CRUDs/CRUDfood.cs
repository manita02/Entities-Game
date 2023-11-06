using crudsGame.src.controllers;
using crudsGame.src.interfaces;
using crudsGame.src.model.Items.Strategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static crudsGame.src.views.Design.MaterialUI;
using MaterialSkin.Controls;
using crudsGame.Properties;
using crudsGame.src.model.Foods;
using MessageBox = crudsGame.src.model.MessageBox;

namespace crudsGame.src.views
{
    public partial class CRUDfood : MaterialForm
    {
        FoodController foodCtn;
        public CRUDfood()
        {
            foodCtn = FoodController.getInstance();
            InitializeComponent();
            LoadMaterial(this);
            LoadFoodsByDefault();
            this.dgvFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbDiet.DataSource = foodCtn.GetDietList();

        }
        int rows = 0;

        private void UpdateFoodId()
        {
            txtId.Text = Convert.ToString(foodCtn.GetFoodList().Count());
        }

        private void LoadFoodsByDefault()
        {
            foreach (var food in foodCtn.GetFoodList())
            {
                LoadFoodIntoDatagrid(dgvFoods.Rows.Add(), food);
            }
        }

        private void LoadFoodIntoDatagrid(int x, Food food)
        {
            dgvFoods.Rows[x].Cells[0].Value = food.id;
            dgvFoods.Rows[x].Cells[1].Value = food.name;
            dgvFoods.Rows[x].Cells[2].Value = food.diet;
            dgvFoods.Rows[x].Cells[3].Value = food.calories;
        }

        public int GetIndexOfDietComboThatComesFromTheDatagrid()
        {
            foreach (var diet in foodCtn.GetDietList())
            {
                if (diet.ToString() == dgvFoods.CurrentRow.Cells[2].Value.ToString())
                {
                    return foodCtn.GetDietList().IndexOf(diet);
                }
            }
            return -1;
        }


        #region Selection Index Changed
        private void dgvFoods_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count > 0)
            {
                this.rows = dgvFoods.SelectedRows[0].Index;
                txtId.Text = dgvFoods.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvFoods.CurrentRow.Cells[1].Value.ToString();
                cbDiet.SelectedIndex = GetIndexOfDietComboThatComesFromTheDatagrid();
                txtCalories.Text = dgvFoods.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void cbDiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDiet.Text)
            {
                case "Carnivore":
                    picDiet.Image = Properties.Resources.carnivore;
                    break;
                case "Herbivorous":
                    picDiet.Image = Properties.Resources.herbivorous;
                    break;
                case "Solar Energy":
                    picDiet.Image = Properties.Resources.solar_energy;
                    break;
            }
        }

        #endregion


        #region Buttons Interactions
        private void btnCreatee_Click(object sender, EventArgs e)
        {
            try
            {
                Food food = foodCtn.CreateFood(foodCtn.GetFoodList().Count(), txtName.Text, GeneralController.CheckThatTheFieldIsNotNull(txtCalories), (IDiet)(cbDiet.SelectedItem));

                if (foodCtn.CheckIfAfoodCreatedWithTheSameNameAlreadyExists(food) == false)
                {
                    foodCtn.AddFood(food);
                    MessageBox.Show("Comida (" + food.name + ") creada satisfactoriamente!!", "Aviso", "Ok", Resources.check);
                    LoadFoodIntoDatagrid(dgvFoods.Rows.Add(), food);
                }
                UpdateFoodId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " por esto no se creará la comida", "Error", "Ok", Resources.error);
            }
        }

        private void btnUpdatee_Click(object sender, EventArgs e)
        {
            MessageBoxDarkMode messageBox = MessageBox.Show("Esta seguro de guardar los cambios??", "ALERTA", "OkCancel", Resources.warning);
            if (model.MessageBox.MessageBoxDialogResult(messageBox) == true)
            {
                try
                {
                    if (dgvFoods.SelectedRows.Count > 0)
                    {
                        Food food = foodCtn.Update(foodCtn.SearchFoodById((int)dgvFoods.CurrentRow.Cells[0].Value), Convert.ToInt32(txtId.Text), txtName.Text, GeneralController.CheckThatTheFieldIsNotNull(txtCalories), (IDiet)(cbDiet.SelectedItem));
                        LoadFoodIntoDatagrid(rows, food);
                        this.rows = 0;
                        MessageBox.Show("Comida actualizada con éxito!!", "Aviso", "Ok", Resources.update);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una fila de la tabla para editar una comida!!", "Error", "Ok", Resources.error);
                    }
                    CleanFields();
                    UpdateFoodId();
                    btnCreatee.Visible = true;
                    btnDeletee.Visible = true;
                    dgvFoods.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " por esto no se editará la comida", "Error", "Ok", Resources.error);
                    btnCreatee.Visible = false;
                    btnDeletee.Visible = false;
                    dgvFoods.Enabled = false;
                }

            }



        }

        private void btnDeletee_Click(object sender, EventArgs e)
        {
            MessageBoxDarkMode messageBox = MessageBox.Show("Esta seguro de guardar los cambios??", "ALERTA", "OkCancel", Resources.warning);
            if (model.MessageBox.MessageBoxDialogResult(messageBox) == true)
            {
                if (dgvFoods.SelectedRows.Count > 0)
                {
                    int row = dgvFoods.CurrentRow.Index;
                    foodCtn.DeleteAfood(row);
                    dgvFoods.Rows.RemoveAt(row);
                    UpdateFoodId();
                    MessageBox.Show("Comida eliminada con éxito!!", "Aviso", "Ok", Resources.delete);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la tabla para editar una comida!!", "Error", "Ok", Resources.error);
                }
                UpdateFoodId();
            }
        }
        #endregion


        private void txtCalories_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtCalories.Text = "";
        }
    }
}
