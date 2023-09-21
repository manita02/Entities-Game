using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Items.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace crudsGame.src.controllers
{
    internal class FoodController
    {
        private static FoodController? Instance;


        private FoodController() { }

        public static FoodController getInstance()
        {
            if (Instance == null)
            {
                Instance = new FoodController();
            }
            return Instance;
        }

        List<string> foodNames = new List<string> { "Lechuga", "Tomate", "Choclo", "Pepino", "Banana", "Manzana", "Durazno", "Pollo", "Vaca", "Cerdo", "Llama", "Cabrito", "Paloma", "Rata", "Comadreja", "Lentejas", "Caramelos", "Chocolates", "Cebada", "Centeno", "Piel de Jabalí", "Rayos De Sol", "Rayos Ultra Violetas", "Corriente Eléctrica", "Rayos Nube - Nube", "Rayos Intra-Nube"};
        List<Food> foodList = new List<Food>();
        List<IDiet> dietList = new List<IDiet>();

        Random random = new Random();
        int index = 0;

        public List<IDiet> GetDietList()
        {
            if (this.dietList.Count == 0)
            {
                dietList.Add(DietCreator.CreateAdiet(1));
                dietList.Add(DietCreator.CreateAdiet(2));
                dietList.Add(DietCreator.CreateAdiet(3));
                dietList.Add(DietCreator.CreateAdiet(4));
            }
            return dietList;
        }

        public List<Food> CreateFoodsMassively()
        {
            this.dietList = GetDietList();

   
            foreach (var name in foodNames)
            {
                if(index <= 6)
                {
                    Food food = new Food(index, name, random.Next(1, 50), dietList[1]);
                    foodList.Add(food);
                }
                if(index > 6 && index <= 13)
                {
                    Food food = new Food(index, name, random.Next(1, 50), dietList[0]);
                    foodList.Add(food);
                }
                if(index > 13 && index <= 20)
                {
                    Food food = new Food(index, name, random.Next(1, 50), dietList[2]);
                    foodList.Add(food);
                }
                if(index > 20)
                {
                    Food food = new Food(index, name, random.Next(1, 50), dietList[3]);
                    foodList.Add(food);
                }

                
                index++;
            }
            MessageBox.Show("total lista: " + foodList.Count);
            return foodList;

        }

        public List<Food> GetFoodList()
        {
            if (foodList.Count == 0)
            {
                return CreateFoodsMassively();
            }
            return this.foodList;
        }


        public Food CreateFood(int id, string name, int calories, IDiet diet)
        {
            return new Food(id, name, calories, diet);

        }

    }
}
