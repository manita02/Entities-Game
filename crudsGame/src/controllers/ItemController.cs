using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
using crudsGame.src.model.Items.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crudsGame.src.controllers
{
    internal class ItemController
    {
        private static ItemController? Instance;


        private ItemController() { }

        public static ItemController getInstance()
        {
            if (Instance == null)
            {
                Instance = new ItemController();
            }
            return Instance;
        }

        List<string> PositiveNames = new List<string> { "Saliva Divina", "Furia de Preyton", "Poción de Bravura", "Poción de Fortaleza", "Néctar Calmante de Esmeralda" };
        List<string> NegativeNames = new List<string> { "Pócima de Donosura", "Ácido de Troll", "Elixir de la Condenación", "Esencia del Caos", "Licor de Tzeentch" };
        List<Item> itemList = new List<Item>();
        List<IStrategyTypeOfItem> interactuables = new List<IStrategyTypeOfItem>();

        List<IKingdom> kingdomsList = new List<IKingdom>();


        Random random = new Random();
        int index = 0;


        public List<IKingdom> GetKingdomList()
        {
            if (kingdomsList.Count == 0)
            {
                kingdomsList.Add(KingdomCreator.CreateAkingdom(1));
                kingdomsList.Add(KingdomCreator.CreateAkingdom(2));
                kingdomsList.Add(KingdomCreator.CreateAkingdom(3));
                kingdomsList.Add(KingdomCreator.CreateAkingdom(4));
            }


            return kingdomsList;
        }

        public List<IStrategyTypeOfItem> GetStrategyItemsList()
        {
            if (interactuables.Count == 0)
            {
                interactuables.Add(new EnergyyItem());
                interactuables.Add(new LifeeItem());
                interactuables.Add(new IncreasesAttackPoints());
                interactuables.Add(new IncreasesDefensePoints());
            }
            return interactuables;
        }


        public List<Item> CreateItemsMassively()
        {
            interactuables = GetStrategyItemsList();
            kingdomsList = GetKingdomList();

            /*
            Item item1 = new Item(index, "caca", GetRandomTypeOfItem(2)); //queda probar con 3 y 4
            itemList.Add(item1);
            index++;
            */

            foreach (var name in PositiveNames)
            {
                Item item = new Item(index, name, interactuables[random.Next(0, interactuables.Count)], kingdomsList[random.Next(0, kingdomsList.Count)]);

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


            //MessageBox.Show("total lista: " + itemList.Count);

            return itemList;

        }

        public List<Item> GetItemList()
        {
            if (itemList.Count == 0)
            {
                return CreateItemsMassively();
            }
            return itemList;
        }


        public Item CreateItem(int id, string name, IStrategyTypeOfItem type, IKingdom kingdom)
        {
            return new Item(id, name, type, kingdom);

        }


    }
}
