using crudsGame.src.controllers;
using crudsGame.src.interfaces;
using crudsGame.src.model;
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

namespace crudsGame.src.views
{
    public partial class CRUDfood : Form
    {
        FoodController foodCtn;
        public CRUDfood()
        {
            foodCtn = FoodController.getInstance();
            InitializeComponent();
            LoadFoodsByDefault();
            this.dgvFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbDiet.DataSource = foodCtn.GetDietList();

        }

        bool exist = false;
        int rows = 0;

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

        private void CheckIfFoodExists(Food food)
        {

            if (foodCtn.GetFoodList().Count > 0)
            {
                for (int fila = 0; fila < dgvFoods.Rows.Count - 1; fila++)
                {

                    if (dgvFoods.Rows[fila].Cells[1].Value.ToString() == food.name)
                    {
                        MessageBox.Show("La comida ' " + food.name + " ' ya existe!!!");
                        exist = true;
                    }
                }
            }

        }

        private bool CheckEmptyFields()
        {
            if (txtName.Text == "" || txtCalories.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos!!!");
                return true;
            }
            return false;
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtCalories.Text = "";
        }

        private void UpdateFoodId()
        {
            txtId.Text = Convert.ToString(foodCtn.GetFoodList().Count());
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields() == false)
            {
                Food food = foodCtn.CreateFood(foodCtn.GetFoodList().Count(), txtName.Text, Convert.ToInt32(txtCalories.Text), (IDiet)(cbDiet.SelectedItem));
                CheckIfFoodExists(food);
                if (exist == false)
                {
                    foodCtn.GetFoodList().Add(food);
                    LoadFoodIntoDatagrid(dgvFoods.Rows.Add(), food);
                }
                exist = false;

                UpdateFoodId();


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count > 0)
            {
                if (CheckEmptyFields() == false)
                {
                    Food food = foodCtn.CreateFood(foodCtn.GetFoodList().Count(), txtName.Text, Convert.ToInt32(txtCalories.Text), (IDiet)(cbDiet.SelectedItem));
                    LoadFoodIntoDatagrid(rows, food);
                    this.rows = 0;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla para editar una comida!!");
            }
            CleanFields();
            UpdateFoodId();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFoods.Rows.Count > 2)
            {
                if (dgvFoods.SelectedRows.Count > 0)
                {
                    int r = dgvFoods.CurrentRow.Index;
                    foodCtn.GetFoodList().RemoveAt(r);
                    dgvFoods.Rows.RemoveAt(r);
                    UpdateFoodId();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la tabla para editar una comida!!");
                }
            }
            else
            {
                MessageBox.Show("Debe existir mas de un comida en la tabla para poder eliminar!!");
            }
            UpdateFoodId();
        }

        private void txtCalories_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralController.ValidateNumbers(e);
        }

        private void cbDiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiet.Text == "Carnivore")
            {
                picDiet.Image = Properties.Resources.carnivore;
            }
            if (cbDiet.Text == "Herbivorous")
            {
                picDiet.Image = Properties.Resources.herbivorous;
            }
            if (cbDiet.Text == "Solar Energy")
            {
                picDiet.Image = Properties.Resources.solar_energy;
            }
        }
    }
}
