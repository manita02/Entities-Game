using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Items.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace crudsGame.src.controllers
{
    internal class EntityController
    {
        private static EntityController? Instance;


        private EntityController() { }

        public static EntityController getInstance()
        {
            if (Instance == null)
            {
                Instance = new EntityController();
            }
            return Instance;
        }


        int index = 0;
        Random random = new Random();
        List<string> RandomNames = new List<string> { "Akuma", "M. Bison", "Zangief", "Ryu", "Sagat", "Dhalsim", "Edmon Honda", "Dee Jay", "Birdie", "Thunder Hawk", "Remy", "Makoto", "Urien", "Necalli", "Ibuki", "Decapre", "Ken", "Chun-Li", "Guile", "Blanka", "Vega", "Fei Long", "Cammy", "Rose", "Charlie Nash", "Dan", "Adon", "Guy", "Sakura", "Rolento", "Karin", "Juni", "Cody", "Maki", "Yun", "Sean", "Necro", "Gen", "Meat"};//37
        List<Entity> EntitiesList = new List<Entity>();
        List<IDiet> DietList = new List<IDiet>();
        List<IKingdom> KingdomList = new List<IKingdom>();
        List<IEnvironment> EnvironmentList = new List<IEnvironment>();
       



        public List<IDiet> GetDietList()
        {
            if (DietList.Count == 0)
            {
                DietList.Add(DietCreator.CreateAdiet(1));
                DietList.Add(DietCreator.CreateAdiet(2));
                DietList.Add(DietCreator.CreateAdiet(3));
                DietList.Add(DietCreator.CreateAdiet(4));
            }
            return DietList;
        }

        public List<IKingdom> GetKingdomList()
        {
            if (KingdomList.Count == 0)
            {
                KingdomList.Add(KingdomCreator.CreateAkingdom(1));
                KingdomList.Add(KingdomCreator.CreateAkingdom(2));
                KingdomList.Add(KingdomCreator.CreateAkingdom(3));
                KingdomList.Add(KingdomCreator.CreateAkingdom(4));
            }
            return KingdomList;
        }

        public List<IEnvironment> GetEnvironmentList()
        {
            if (EnvironmentList.Count == 0)
            {
                EnvironmentList.Add(EnvironmentCreator.CreateAenvironment(1));
                EnvironmentList.Add(EnvironmentCreator.CreateAenvironment(2));
                EnvironmentList.Add(EnvironmentCreator.CreateAenvironment(3));
            }
            return EnvironmentList;
        }

       
        public List<Entity> GetEntitiesList()
        {
            if (EntitiesList.Count == 0)
            {
                return CreateEntitiesMassively();
            }
            return EntitiesList;
        }

        private List<IEnvironment> GenerateRandomListOfEnvironments(int randomNumber)
        {
            List<IEnvironment> lista = new List<IEnvironment>();
            if (randomNumber % 3 == 0)
            {
                lista.Add(EnvironmentList[random.Next(0, EnvironmentList.Count)]);
            }
            else
            {
                if (randomNumber % 2 == 0)
                {
                    lista.Add(EnvironmentList[0]);
                    lista.Add(EnvironmentList[1]);
                }
                else
                {
                    lista.Add(EnvironmentList[0]);
                    lista.Add(EnvironmentList[1]);
                    lista.Add(EnvironmentList[2]);
                }
            }
            return lista;
        }


        public List<Entity> CreateEntitiesMassively()
        {
            DietList = GetDietList();
            EnvironmentList = GetEnvironmentList();
            KingdomList = GetKingdomList();

            Entity testEntity = new Entity(index, KingdomList[1], "pruebass", DietList[random.Next(0, DietList.Count)], GenerateRandomListOfEnvironments(random.Next(0,100)), random.Next(300, 500), random.Next(300, 500), 30, 30, random.Next(0, 2));
            EntitiesList.Add(testEntity);
            index++;

            foreach (var name in RandomNames)
            {
                Entity entity = new Entity(index, KingdomList[random.Next(0, KingdomList.Count)], name, DietList[random.Next(0, DietList.Count)], GenerateRandomListOfEnvironments(random.Next(0, 100)), random.Next(300, 500), random.Next(300, 500), random.Next(100, 400), random.Next(100, 400), random.Next(0, 2));
                EntitiesList.Add(entity);
                index++;
            }
            MessageBox.Show("total lista: " + EntitiesList.Count);
            return EntitiesList;
        }

      
        public Entity CreateEntity(int id, IKingdom kingdom, string name, IDiet diet, List<IEnvironment> environments, int maxEnergy, int maxLife, int attack, int defense, int range)
        {
            return new Entity(id, kingdom, name, diet, environments, maxEnergy, maxLife, attack, defense, range);
        }

        public Entity Update(Entity entity, int id, IKingdom kingdom, string name, IDiet diet, List<IEnvironment> environments, int maxEnergy, int maxLife, int attack, int defense, int range)
        {
            entity.id = id;
            entity.kingdom = kingdom;
            entity.name = name;
            entity.diet = diet;
            entity.environmentList = environments;
            entity.maxEnergy = maxEnergy;
            entity.maxLife = maxLife;
            entity.attackPoints = attack;
            entity.defensePoints = defense;
            entity.attackRange = range;

            return entity;
        }

        public void AddEntity(Entity entity)
        {
            EntitiesList.Add(entity);
        }
 
        public Entity SearchEntityById(int id)
        {
            foreach (var ent in EntitiesList)
            {
                if (ent.id == id)
                {
                    return ent;
                }
            }
            return null;
        }

        public bool VerifyIfTheItemListboxEnvironmentIsInTheListOfEnvironmentsItself(Entity entity, IEnvironment checkedEnvironment)
        {
            for (int i = 0; i < entity.environmentList.Count; i++)
            {
                if (checkedEnvironment == entity.environmentList[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckIfAnEntityCreatedWithTheSameNameAlreadyExists(Entity entity)
        {
            foreach (Entity e in EntitiesList)
            {
                if (e.name == entity.name)
                {
                    throw new Exception("Ya existe una entidad con el mismo nombre (" + entity.name + ")");
                }
            }
            return false;
            
        }

        public void DeleteAnEntity(int row)
        {
            EntitiesList.RemoveAt(row);
        }
    }
}
