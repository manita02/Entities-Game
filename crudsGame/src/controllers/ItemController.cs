using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Items;
using crudsGame.src.model.Items.Strategy;
using crudsGame.src.model.Items.Strategy.Negatives;
using crudsGame.src.model.Items.Strategy.Positive;
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

        List<string> ItemNames = new List<string> { "Saliva Divina", "Furia de Preyton", "Poción de Bravura", "Poción de Fortaleza", "Néctar Calmante de Esmeralda", "Posición de Agilidad", "Posición de Brazos de Araña", "Coraje Líquido", "Favor de Greta", "Posición de Fuerza Diabólica", "Posición de Ingenio", "Posición de Liderazgo", "Posición de Suerte", "Tónico de Lucidez", "Posición de Sigilo", "Posición de Respuesta", "Posición de Ojos de Gato", "Néctar de la Belleza", "Pócima de Donosura", "Ácido de Troll", "Elixir de la Condenación", "Esencia del Caos", "Licor de Tzeentch", "Vena en Polvo", "Último Aliento", "Poción de Terror", "Posición de Torpeza", "Sangre Mareal", "Sangre Ciega", "Skalm", "Poción de Respirar Fuego", "Poción de Piedra", "Poción de Ojos de Águila", "Poción de Ojos de Búho", "Poción Maldita", "Licor Vidente de Serpiente", "Licor Adelgazante", "Leche de La Asamblea", "Poción Ojos de Rata", "Poción Murciélago" };
        List<Item> ItemList = new List<Item>();
        List<IStrategyTypeOfItem> StrategyTypeItems = new List<IStrategyTypeOfItem>();
        List<IKingdom> KingdomsList = new List<IKingdom>();


        Random random = new Random();
        int index = 0;


        public List<IKingdom> GetKingdomList()
        {
            if (KingdomsList.Count == 0)
            {
                KingdomsList.Add(KingdomCreator.CreateAkingdom(1));
                KingdomsList.Add(KingdomCreator.CreateAkingdom(2));
                KingdomsList.Add(KingdomCreator.CreateAkingdom(3));
                KingdomsList.Add(KingdomCreator.CreateAkingdom(4));
            }
            return KingdomsList;
        }

        public List<IStrategyTypeOfItem> GetStrategyItemsList()
        {
            if (StrategyTypeItems.Count == 0)
            {
                StrategyTypeItems.Add(new EnergyyItem());
                StrategyTypeItems.Add(new LifeeItem());
                StrategyTypeItems.Add(new IncreasesAttackPoints());
                StrategyTypeItems.Add(new IncreasesDefensePoints());
                StrategyTypeItems.Add(new LosesEnergy());
                StrategyTypeItems.Add(new LosesLife());
                StrategyTypeItems.Add(new LosesAttackPoints());
                StrategyTypeItems.Add(new LosesDefensePoints());
            }
            return StrategyTypeItems;
        }


        public List<Item> CreateItemsMassively()
        {
            StrategyTypeItems = GetStrategyItemsList();
            KingdomsList = GetKingdomList();
            
            foreach (var name in ItemNames)
            {
                if (index <= 17)
                {
                    Item item = new Item(index, name, StrategyTypeItems[random.Next(0, 4)], KingdomsList[random.Next(0, KingdomsList.Count)]); //positivos
                    ItemList.Add(item);
                }
                else
                {
                    Item item = new Item(index, name, StrategyTypeItems[random.Next(4, StrategyTypeItems.Count)], KingdomsList[random.Next(0, KingdomsList.Count)]); //negativos
                    ItemList.Add(item);
                }
                index++;
            }
            return ItemList;
        }

        public List<Item> GetItemList()
        {
            if (ItemList.Count == 0)
            {
                return CreateItemsMassively();
            }
            return ItemList;
        }


        public Item CreateItem(int id, string name, IStrategyTypeOfItem type, IKingdom kingdom)
        {
            return new Item(id, name, type, kingdom);
        }

        public bool CheckIfAitemCreatedWithTheSameNameAlreadyExists(Item item)
        {
            foreach (Item i in ItemList)
            {
                if (i.name == item.name)
                {
                    throw new Exception("Ya existe un item con el mismo nombre (" + item.name + ")");
                }
            }
            return false;

        }

        public void AddItem(Item item)
        {
            ItemList.Add(item);
        }

        public void DeleteAitem(int row)
        {
            ItemList.RemoveAt(row);
        }

        public Item SearchItemById(int id)
        {
            foreach (var item in ItemList)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Item Update(Item item, int id, string name, IStrategyTypeOfItem type, IKingdom kingdom)
        {
            item.id = id;
            item.name = name;
            item.itemStrategy = type;
            item.kingdom = kingdom;
            return item;
        }

    }
}
