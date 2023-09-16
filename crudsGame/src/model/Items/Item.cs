using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crudsGame.src.model.Items
{
    public class Item
    {
        int Id { get; set; }
        string Name { get; set; }
        int Valuee;
        IInteractuable ItemStrategy;

        public Item(int id, string name, int value)
        {
            Id = id;
            Name = name;
            Valuee = value;

        }

        public int Value
        {
            set {
                if (value < 0 || value > 70)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                      "The valid range for item is between 0 and 70.");
                }
                else {
                    Valuee = value;
                }
                }
            get { return Valuee; }
        }


        public void SetItemSrategy(IInteractuable itemStrategy)
        {
            ItemStrategy = itemStrategy;
        }

        public void ApplyInteraction(IEntity entity, int value)
        {
            this.ItemStrategy.Interact(entity ,value);
        }

        public override string ToString()
        {
            return Name;
        }



    }








}
