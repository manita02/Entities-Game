using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crudsGame.src.model.Items
{
    public class Item : IInteractuable
    {
        int Id { get; set; }
        string Name { get; set; }
        IStrategyTypeOfItem ItemStrategy { get; set; }

        IKingdom Kingdom;

        public Item(int id, string namee, IStrategyTypeOfItem itemStrategy, IKingdom kingdom)
        {
            Id = id;
            name = namee;
            ItemStrategy = itemStrategy;
            Kingdom = kingdom;
        }

        public int id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Name = value;
                }
                else throw new Exception("The name cannot be empty!!");
            }
        }

        public IStrategyTypeOfItem itemStrategy
        {
            get
            {
                return ItemStrategy;
            }
            set
            {
                if (value != null)
                {
                    ItemStrategy = value;
                }
                else throw new Exception("You have to select a type of item");
            }
        }

        public IKingdom kingdom
        {
            get
            {
                return Kingdom;
            }
            set
            {
                if (value != null)
                {
                    Kingdom = value;
                }
                else throw new Exception("You have to select a kingdom");
            }
        }


        public override string ToString()
        {
            return Name +"_"+ Kingdom;
        }

        public void Interact(Entity entity)
        {
            //try {
            /*
                if (ItemStrategy.ApplyItem(entity) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }*/
                ItemStrategy.ApplyItem(entity);
                //entity.currentEnergy -= 10;

            //}
            //catch(Exception e)
            //{
                //Console.WriteLine(e.ToString());
                //return false;
            //}

            
            /*

            if (ItemStrategy.ApplyItem(entity) == true)
            {
                entity.currentEnergy -= 10;
            }
            */



        }
    }








}
