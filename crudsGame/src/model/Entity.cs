﻿using crudsGame.src.interfaces;
using crudsGame.src.model.Kingdoms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model
{
    public class Entity : IPositionable
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

        public IEnvironment environment
        {
            get
            {
                return Environment;
            }

            set
            {
                if (value != null)
                {
                    Environment = value;
                }
                else throw new InvalidOperationException("You have to select a environment");
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
                else throw new NullReferenceException("The name cannot be empty!!");
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
                else throw new InvalidOperationException("You have to select a kingdom");
            }
        }


        public IDiet diet
        {
            get
            {
                return Diet;
            }

            set
            {
                if (value != null)
                {
                    Diet = value;
                }
                else throw new InvalidOperationException("You have to select a diet");
            }
        }


        public int currentEnergy
        {
            get
            {
                return CurrentEnergy;
            }
            set
            {
                if (value < 0)
                {
                    CurrentEnergy = 0;
                    MessageBox.Show("The creature" + Name + " is very tired");
                    throw new Exception("The creature "+ Name +" is very tired");
                }
                else if (value > MaxEnergy)
                {
                    CurrentEnergy = MaxEnergy;
                }
                else
                {
                    CurrentEnergy = value;
                }
            }
        }


        public int maxEnergy
        {
            get
            {
                return MaxEnergy;
            }

            set
            {
                if (value > 0)
                {
                    //MessageBox.Show("ENTRE: " + this.CurrentEnergy);
                    MaxEnergy = value;
                }
                else throw new InvalidOperationException("la energia maxima esta mal");
            }
        }

        public int maxLife
        {
            get => MaxLife;
            //get { return maxLife; }
            set
            {
                if (value > 0) MaxLife = value;
                else throw new InvalidOperationException("la vida siempre sera mayor a 0");
            }
        }

        public int attackPoints {
            get
            {
                return AttackPoints;
            }

            set
            {
                if (value >= 10 && value <= 80)
                {
                    AttackPoints = value;
                }
                else
                    AttackPoints = 80;
                    throw new ArgumentOutOfRangeException(nameof(value), "The valid range for attack points is between 10 and 80.");
            }
        }


        public int defensePoints {
            get
            {
                return DefensePoints;
            }

            set
            {
                if (value >= 10 && value <= 80)
                {
                    DefensePoints = value;
                }
                else
                    DefensePoints = 80;
                    throw new ArgumentOutOfRangeException(nameof(value), "The valid range for defense points is between 10 and 80.");

            }
        }
        public int currentLife
        {
            get
            {
                return CurrentLife;
            }
            set
            {
                if (value <= 0)
                {
                    CurrentLife = 0;
                    
                    MessageBox.Show("The creature "+ Name +" has died");
                    throw new Exception("The creature " + Name + " has died");
                    
                }
                else if (value > MaxLife)
                {
                    CurrentLife = MaxLife;
                }
                else
                {
                    CurrentLife = value;
                }
            }
        }

        public int attackRange
        {
            get
            {
                return AttackRange;
            }

            set
            {
                if (value >= 0 && value <= 1)
                {
                    AttackRange = value;
                }
                else throw new ArgumentOutOfRangeException(nameof(value), "Attack Range can be 0 (zero) or 1 (one)");

            }
        }


        public int Attack(Entity entity, int valorDadoJ1, int valorDadoJ2)
        {
            this.CurrentEnergy -= 5;
            return (entity.currentLife - (this.AttackPoints + valorDadoJ1) + entity.defensePoints + valorDadoJ2);
             //chequear los valores de dado
            //vida atacado = vida atacado - ( ( defAtacado + ResultadoDado ) - ( AtkAtacante + ResultadoDado ) )
        }

        /*
        public string mostrarParaDefenseCreature()
        {
            return this.Name + "/" + this.Kingdom.ToString() + "/ atk: " + this.AttackPoints + "/ def: " + this.DefensePoints + "/ range: " + this.AttackRange + "/ C.Energy: " +this.CurrentEnergy+ "/ C.Life: "+this.CurrentLife;

        }
        */

        
        public void Eat(Entity entity,  Food food)
        {
            if (Diet.CanEat(entity,food) == true)
            {
                food.Interact(entity);
                //entity.currentEnergy -= 10;
            }
            else
            {
                MessageBox.Show("la entidad seleccionada no puede comer este alimento");
            }
            
        }
        


        public string ShowMainCreature()
        {
            //return this.Name + "/" +  this.Kingdom.ToString() + "/ atk: " + this.AttackPoints + "/ def: " + this.DefensePoints + "/ range: " + this.AttackRange;
            return this.Name;
        }

        public void Sleep()
        {
            this.currentEnergy += 50; //hay q llamr a los getters xq ya tienen hechas las validaciones
            this.currentLife += this.maxLife; 
        }

        //lo q queda seria generar automaticamente las entidades con otro masssive  creator para probar y despues conectarlo a los crudss  
    }
}
