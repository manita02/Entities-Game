using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items
{
    /*
    internal class LifeItem : IInteractuable
    {
        int Id;
        string Name;
        int Value;
        bool Type; //pos or neg

        public LifeItem() { }
        public LifeItem(int id, string name, int value, bool type)
        {
            Id = id;
            Name = name;
            //MessageBox.Show("nombre: " + Name);
            Value = value;
            Type = type;
        }

        int IInteractuable.Id { get => this.Id; set => this.Id = value; }
        string IInteractuable.Name { get => this.Name; set => this.Name = value; }
        bool IInteractuable.Type { get => this.Type; set => this.Type = value; }
        int IInteractuable.Value { get => this.Value; set => this.Value = value; }

        public void Interact(IEntity entity)
        {
            int l = entity.CurrentLife;
            if (this.Type == true)
            {
                l += Value;
            }
            else
            {
                l -= Value;
            }
        }

        public override string ToString()
        {
            return "Affects life";
        }
    }
    */
}


