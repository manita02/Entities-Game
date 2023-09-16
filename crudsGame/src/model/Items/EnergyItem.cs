using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items
    
{
    /*
    internal class EnergyItem : IInteractuable
    {
        int Id;
        string Name;
        int Value;
        bool Type; //pos or neg

        public EnergyItem() { }
        public EnergyItem(int id, string name, int value, bool type)
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
        /*
        if (value > 0)
                {
                    Value = value;
                }
                else
                {
                    MessageBox.Show("El valor a ingresar debe ser mayor a cero");
                }
        
        public void Interact(IEntity entity)
        {
            int e = entity.CurrentEnergy;
            if (this.Type == true)
            {
                e += Value;
            }
            else {
                e -= Value;
            }
        }

        public override string ToString()
        {
            return "Affects energy";
        }


    }
    */
}

