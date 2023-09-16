using crudsGame.src.interfaces;
using crudsGame.src.model.Kingdoms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model
{
    internal class Entity : IEntity, IPositionable
    {
        int Id;
        IKingdom Kingdom;
        string Name;
        IDiet Diet;
        IEnvironment Environment;
        int MaxEnergy;
        int CurrentEnergy;
        int MaxLife;
        int CurrentLife;
        int AttackPoints;
        int DefensePoints;
        int AttackRange;

        public Entity(int id, IKingdom kingdom, string name, IDiet diet, IEnvironment environment, int maxenergy, int currentenergy, int maxlife, int currentlife, int attackpoints, int defensepoints, int attackrange)
        {
            Id = id;
            Kingdom = kingdom;
            Name = name;
            Diet = diet;
            Environment = environment;
            MaxEnergy = maxenergy;
            CurrentEnergy = currentenergy;
            MaxLife = maxlife;
            CurrentLife = currentlife;
            AttackPoints = attackpoints;
            DefensePoints = defensepoints;
            AttackRange = attackrange;
        }

        string IEntity.Name { get => this.Name; set => this.Name = value ; }
        IEnvironment IEntity.Environment { get => this.Environment; set => this.Environment = value ; }
        IDiet IEntity.Diet { get => this.Diet; set => this.Diet = value; }
        int IEntity.MaxEnergy { get => this.MaxEnergy; set => this.MaxEnergy = value; }
        int IEntity.CurrentEnergy { get => this.CurrentEnergy; set => this.CurrentEnergy = value; }
        int IEntity.MaxLife { get => this.MaxLife; set => this.MaxLife = value; }
        int IEntity.CurrentLife { get => this.CurrentLife; set => this.CurrentLife = value; }
        int IEntity.AttackPoints { get => this.AttackPoints; set => this.AttackPoints = value; }
        int IEntity.DefensePoints { get => this.DefensePoints; set => this.DefensePoints = value; }
        int IEntity.AttackRange { get => this.AttackRange; set => this.AttackRange = value; }
        int IEntity.Id { get => this.Id; set => this.Id = value; }
        IKingdom IEntity.Kingdom { get => this.Kingdom; set => this.Kingdom = value; }

        public int Attack(IEntity entity, int valorDadoJ1, int valorDadoJ2)
        {
            this.CurrentEnergy -= 5;
            return (entity.CurrentLife - (this.AttackPoints + valorDadoJ1) + entity.DefensePoints + valorDadoJ2);
             //chequear los valores de dado
            //vida atacado = vida atacado - ( ( defAtacado + ResultadoDado ) - ( AtkAtacante + ResultadoDado ) )
        }

        /*
        public string mostrarParaDefenseCreature()
        {
            return this.Name + "/" + this.Kingdom.ToString() + "/ atk: " + this.AttackPoints + "/ def: " + this.DefensePoints + "/ range: " + this.AttackRange + "/ C.Energy: " +this.CurrentEnergy+ "/ C.Life: "+this.CurrentLife;

        }
        */

        public string ShowMainCreature()
        {
            return this.Name + "/" +  this.Kingdom.ToString() + "/ atk: " + this.AttackPoints + "/ def: " + this.DefensePoints + "/ range: " + this.AttackRange;
        }

        public int Sleep()
        {
            throw new NotImplementedException();
        }

        
    }
}
