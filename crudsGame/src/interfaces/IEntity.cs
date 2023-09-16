using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.interfaces
{
    public interface IEntity
    {
        string Name { get; set;}
        IEnvironment Environment { get; set; }
        IDiet Diet { get; set; } //los vegetales deben comer energia solar
        int MaxEnergy { get; set; }
        int CurrentEnergy { get; set; }
        int MaxLife { get; set; }
        int CurrentLife { get; set; }
        int AttackPoints { get; set; }
        int DefensePoints { get; set; }
        int AttackRange { get; set; }
        int Id { get; set; }
        IKingdom Kingdom { get; set; }
        int Attack(IEntity entity, int valorDadoJ1, int valorDadoJ2);
        int Sleep();

        string ShowMainCreature();

        



        //int Interact(IInteractuable item);

        //int Eat(IFood food); //comen energia solar  las plantas

        //string ForCbEntities();

        //string ForCbFoods();

        //string GetSpecie();
    }
}
