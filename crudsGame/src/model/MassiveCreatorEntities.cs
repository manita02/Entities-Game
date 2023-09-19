using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model.Items.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace crudsGame.src.model
{
    internal class MassiveCreatorEntities
    {
        private static MassiveCreatorEntities? Instance;


        private MassiveCreatorEntities() { }

        public static MassiveCreatorEntities getInstance()
        {
            if (Instance == null)
            {
                Instance = new MassiveCreatorEntities();
            }
            return Instance;
        }


        int index = 0;
        Random random = new Random();
        List<string> RandomNames = new List<string> { "Akuma", "M. Bison", "Zangief", "Ryu", "Sagat", "Dhalsim", "Edmon Honda", "Dee Jay", "Birdie", "Thunder Hawk", "Remy", "Makoto", "Urien", "Necalli", "Ibuki", "Decapre"};
        List<Entity> EntitiesList = new List<Entity>();
        List<IDiet> DietList = new List<IDiet>();
        List<IKingdom> KingdomList = new List<IKingdom>();
        List<IEnvironment> EnvironmentList = new List<IEnvironment>();

        

        public List<IDiet> GetDietList()
        {
            DietList.Add(DietCreator.CreateAdiet(1));
            DietList.Add(DietCreator.CreateAdiet(2));
            DietList.Add(DietCreator.CreateAdiet(3));
            DietList.Add(DietCreator.CreateAdiet(4));

            return DietList;
        }

        public List<IKingdom> GetKingdomList()
        {
            KingdomList.Add(KingdomCreator.CreateAkingdom(1));
            KingdomList.Add(KingdomCreator.CreateAkingdom(2));
            KingdomList.Add(KingdomCreator.CreateAkingdom(3));
            KingdomList.Add(KingdomCreator.CreateAkingdom(4));

            return KingdomList;
        }

        public List<IEnvironment> GetEnvironmentList()
        {
            EnvironmentList.Add(EnvironmentCreator.CreateAenvironment(1));
            EnvironmentList.Add(EnvironmentCreator.CreateAenvironment(2));
            EnvironmentList.Add(EnvironmentCreator.CreateAenvironment(3));

            return EnvironmentList;
        }


        public List<Entity> GetEntitiesList()
        {
            if(this.EntitiesList.Count == 0)
            {
                MessageBox.Show("estoy");
                return CreateEntitiesMassively();
            }
            return this.EntitiesList;
        }


        public List<Entity> CreateEntitiesMassively()
        {
            this.DietList = GetDietList();
            this.EnvironmentList = GetEnvironmentList();
            this.KingdomList = GetKingdomList();

            Entity item1 = new Entity (index, KingdomList[random.Next(0, KingdomList.Count)], "caga", DietList[random.Next(0, DietList.Count)], EnvironmentList[random.Next(0, EnvironmentList.Count)], 23, 20, 10, 5, random.Next(0, 1));
            EntitiesList.Add(item1);
            index++;

            foreach (var name in RandomNames)
            {
                Entity entity = new Entity(index, KingdomList[random.Next(0, KingdomList.Count)], name, DietList[random.Next(0, DietList.Count)], EnvironmentList[random.Next(0, EnvironmentList.Count)], 100, 100, random.Next(10, 80), random.Next(10, 80), random.Next(0,1));
                //MessageBox.Show("id: " + entity.id + " NAME: " + entity.name);
                EntitiesList.Add(entity);
                index++;
            }

            MessageBox.Show("total lista: " + EntitiesList.Count);

            return EntitiesList;
        }
        
    }
}
