using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
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

        public Entity(int id, IKingdom kingdom, string name, IDiet diet, IEnvironment environment, int maxenergy, int maxlife, int attackpoints, int defensepoints, int attackrange)
        {
            Id = id;
            Kingdom = kingdom;
            Name = name;
            Diet = diet;
            Environment = environment;
            MaxEnergy = maxenergy;
            CurrentEnergy = MaxEnergy;
            MaxLife = maxlife;
            CurrentLife = MaxLife;
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

        public int attackPoints { //aca hay errores
            get
            {
                return AttackPoints;
            }

            set
            {
                /*
                if (value >= 80)
                {
                    AttackPoints = 80;
                }
                else
                {
                    AttackPoints = value;
                }
                */

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
                if (value == 0 || value == 1)
                {
                    AttackRange = value;
                }
                if (value > 0)
                {
                    MessageBox.Show("El ataque solo puede ser 0 o 1");
                    AttackRange = 1;
                }
                
                else throw new ArgumentOutOfRangeException(nameof(value), "Attack Range can be 0 (zero) or 1 (one)");

            }
        }


        public int Attack(Entity entity)
        {
            try
            {
                this.currentEnergy -= 10;

                int DicePlayerOne = Dice.TrowDice();
                int DicePlayerTwo = Dice.TrowDice();


                MessageBox.Show("\t Player one ha lanzado el dado: +" + DicePlayerOne + "\n \t " + this.name + " ataca con (" + this.attackPoints + " + " + DicePlayerOne + ") a " + entity.name);
                MessageBox.Show("\t Player two ha lanzado el dado: +" + DicePlayerTwo + "\n \t " + entity.name + " se defenderá con (" + entity.defensePoints + " + " + DicePlayerTwo);

                

                return ((this.attackPoints + DicePlayerOne) - entity.defensePoints + DicePlayerTwo);
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return 0;
            }
            
        }

        public void BeingAttacked(int atkPoints, Entity entity)
        {
            try
            {
               
                        if (atkPoints < 0)
                        {
                            this.currentLife += atkPoints;
                            MessageBox.Show("Ganó " + entity.name + "con sus puntos de defensa!!");
                        }
                        else
                        {
                            if(atkPoints > 0)
                            {
                                entity.currentLife -= atkPoints;
                                MessageBox.Show("Ganó " + this.name + "con sus puntos de ataque!!");
                            }
                        }
                   
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
             
        }


        public void UsarItem(Entity entity, Item item)
        {
            if (Kingdom.CanInteract(entity, item) == true)
            {
                item.Interact(entity);
            }
            else
            {
                MessageBox.Show("la entidad seleccionada no puede usar este item");
            }
        }

        public void Eat(Entity entity,  Food food)
        {
            try
            {
                if (Diet.CanEat(entity, food) == true)
                {
                    food.Interact(entity);
                    //entity.currentEnergy -= 10;
                }
                else
                {
                    MessageBox.Show("la entidad seleccionada no puede comer este alimento");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            
        }

        public override string ToString()
        {
            return this.Name;
        }

        

        /*
        public string ShowMainCreature()
        {
            //return this.Name + "/" +  this.Kingdom.ToString() + "/ atk: " + this.AttackPoints + "/ def: " + this.DefensePoints + "/ range: " + this.AttackRange;
            return this.Name;
        }
        */
        public void Sleep()
        {
            this.currentEnergy += 50; //hay q llamr a los getters xq ya tienen hechas las validaciones
            this.currentLife += this.maxLife; 
        }

        //lo q queda seria generar automaticamente las entidades con otro masssive  creator para probar y despues conectarlo a los crudss  
    }
}
