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

        List<string> foodNames = new List<string> { "Lechuga", "Tomate", "Choclo", "Pepino", "Banana", "Manzana", "Durazno", "Mandarina", "Acelga", "Rabanito", "Zapallo", "Uva", "Pollo", "Vaca", "Cerdo", "Llama", "Cabrito", "Paloma", "Rata", "Serpiente", "Sapo", "Liebre", "Conejo", "Coatí", "Rayos De Sol", "Rayos Ultra Violetas", "Corriente Eléctrica", "Rayos Nube - Nube", "Rayos Intra-Nube", "Netbook eNova", "Iphone X", "Samsung Galaxy J7", "Intel core i5-11400",  "TV LED RCA",  "Microondas",  "Heladera", "PC Gamer", "Amplificador 50 Watts", "Guitarra Eléctrica", "Batería Eléctrica" };
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
                //dietList.Add(DietCreator.CreateAdiet(3));
                dietList.Add(DietCreator.CreateAdiet(4));
            }
            return dietList;
        }

        public List<Food> CreateFoodsMassively()
        {
            this.dietList = GetDietList();

   
            foreach (var name in foodNames)
            {
                if(index <= 11)
                {
                    Food food = new Food(index, name, random.Next(1, 50), dietList[1]);//herbiboro
                    foodList.Add(food);
                }
                if(index > 11 && index <= 23)
                {
                    Food food = new Food(index, name, random.Next(1, 50), dietList[0]);//carnivoro
                    foodList.Add(food);
                }
                
                if(index > 23)
                {
                    Food food = new Food(index, name, random.Next(1, 50), dietList[2]);//solar
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

        public bool CheckIfAfoodCreatedWithTheSameNameAlreadyExists(Food food)
        {
            foreach (Food f in foodList)
            {
                if (f.name == f.name)
                {
                    //EntitiesList.Remove(entity);
                    //MessageBox.Show("existe");
                    throw new Exception("Ya existe una comida con el mismo nombre (" + food.name + ")");
                }
            }
            return false;

        }

        public void AddFood(Food food)
        {
            foodList.Add(food);
        }

        public void DeleteAfood(int row)
        {
            foodList.RemoveAt(row);
        }

        public Food SearchFoodById(int id)
        {
            foreach (var food in foodList)
            {
                if (food.id == id)
                {
                    return food;
                }
            }
            return null;
        }

        public Food Update(Food food, int id, string name, int calories, IDiet diet)
        {
            food.id = id;
            food.name = name;
            food.diet = diet;
            food.calories = calories;
            return food;
        }

    }
}
