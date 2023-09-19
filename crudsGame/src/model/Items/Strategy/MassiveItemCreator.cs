using crudsGame.src.controllers;
using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crudsGame.src.model.Items.Strategy
{
    internal class MassiveItemCreator
    {
        private static MassiveItemCreator? Instance;


        private MassiveItemCreator() { }

        public static MassiveItemCreator getInstance()
        {
            if (Instance == null)
            {
                Instance = new MassiveItemCreator();
            }
            return Instance;
        }

        List<string> PositiveNames = new List<string> { "Saliva Divina", "Furia de Preyton", "Poción de Bravura", "Poción de Fortaleza", "Néctar Calmante de Esmeralda" };
        List<string> NegativeNames = new List<string> { "Pócima de Donosura", "Ácido de Troll", "Elixir de la Condenación", "Esencia del Caos", "Licor de Tzeentch" };
        List<Item> itemList = new List<Item>();
        List<IStrategyTypeOfItem> interactuables = new List<IStrategyTypeOfItem>();
        Random random = new Random();
        int index = 0;



        public List<IStrategyTypeOfItem> LoadTypesOfItems()
        {
            interactuables.Add(new EnergyyItem());
            interactuables.Add(new LifeeItem());
            interactuables.Add(new IncreasesAttackPoints());
            interactuables.Add(new IncreasesDefensePoints());

            return interactuables;
        }

        
        public IStrategyTypeOfItem GetRandomTypeOfItem(int randomIndex)
        {
            return interactuables[randomIndex];

        }
        

        public List<Item> CreateItemsMassively()
        {
            this.interactuables = LoadTypesOfItems();

            Item item1 = new Item(index, "caca", GetRandomTypeOfItem(2)); //queda probar con 3 y 4
            itemList.Add(item1);
            index++;

            foreach (var name in PositiveNames)
            {
                
                Item item = new Item(index, name, GetRandomTypeOfItem(random.Next(0, interactuables.Count)));
                  
                itemList.Add(item);
                index++;

                
                   
            }

            
            /* podrian estar todos en la misma lista de nombres de una y no en separados que del i 0 hasta el 5 busque index positivos y el resto que busque en los negativoss
            foreach (var nameN in NegativeNames)
            {
                
                    Item itemNeg = new Item(index, nameN, GetRandomTypeOfItem(random.Next(0, interactuables.Count)));
                    itemList.Add(itemNeg);
                    //MessageBox.Show("Count: " + i + " _name: " + nameN);
                    index++;

           
            }
            */

          
            MessageBox.Show("total lista: " + itemList.Count);

            return itemList;

        }

        public List<Item> getLista()
        {
            return this.itemList;
        }

        
    }
}
