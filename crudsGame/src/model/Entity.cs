using crudsGame.Properties;
using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
using crudsGame.src.model.Kingdoms;
using crudsGame.src.views;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
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
        List<IEnvironment> EnvironmentsList = new List<IEnvironment>();
        int MaxEnergy;
        int CurrentEnergy;
        int MaxLife;
        int CurrentLife;
        int AttackPoints;
        int DefensePoints;
        int AttackRange;


        
        public Entity(int id, IKingdom kingdomm, string namee, IDiet diet, List<IEnvironment> environments, int maxenergy, int maxlifee, int attackpoints, int defensepoints, int attackrange)
        {
            Id = id;
            kingdom = kingdomm; //aca hay q usar las propiedadesss, el metodo que hay q modificar siempre es el set
            name = namee;
            Diet = diet;
            environmentList = environments;
            maxEnergy = maxenergy;
            CurrentEnergy = MaxEnergy;
            maxLife = maxlifee;
            CurrentLife = MaxLife;
            attackPoints = attackpoints;
            defensePoints = defensepoints;
            attackRange = attackrange;
        }



        /*
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
        */

        #region Properties

        public List<IEnvironment> environmentList
        {
            get
            {
                
                    //if (EnvironmentsList.Count() != 0) //|| EnvironmentsList!=null)//nova el null
                    //{
                        return EnvironmentsList;

                    //}
                    //else
                    //{
                        //throw new Exception("Debe seleccionar por lo menos un environment para la criatura " + Name);

                    //}        
            }
            set
            {
                if (value.Count() != 0)
                {
                    EnvironmentsList = value;

                }
                else
                {
                    throw new Exception("Tiene que seleccionar como mínimo un ambiente para la criatura " + Name);
                } 
            }
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

        /*
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
        */

        public string name
        {
            get
            {
                  
                //if (!string.IsNullOrEmpty(Name))
                //{
                    return Name;
                //}
                //else
                //{
                    //throw new Exception("Debe asignarle un nombre a esta entidad!!");
                //}
                
                
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
                    //MessageBox.Show("The creature" + Name + " is very tired");
                    throw new Exception("The creature "+ Name +" is very tired");
                }
                else if (value >= MaxEnergy)
                {
                    CurrentEnergy = MaxEnergy;
                    throw new Exception("La entidad "+this.Name+" tiene lo máximo que puede obtener en energía ( "+this.MaxEnergy+" )");

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
                    MaxEnergy = value;
                }
                else
                {
                    throw new Exception("La energía máxima debe ser mayor a cero!!");
                }       
            }
        }

        public int maxLife
        {
            get
            {
                return MaxLife;
            }
            set
            {
                if (value > 0)
                {
                    MaxLife = value;
                }
                else
                {
                    throw new Exception("La vida máxima debe ser mayor a cero!!");
                } 
            }
        }





        public int attackPoints
        {
            get
            { 
                return AttackPoints;
            }

            set
            {
                
                if (value > 0)
                {
                    AttackPoints = value;
                }
                else
                {
                    AttackPoints = 0;
                    throw new Exception("La entidad " + this.Name + " ha perdido todos sus puntos de ataque debido a que ha utilizado un item!!");

                }
            }
        }

        
        public int defensePoints {
            get
            { 
               return DefensePoints; 
            }

            set
            {
                if (value > 0)
                {
                    DefensePoints = value;
                }
                else
                {
                    DefensePoints = 0;
                    throw new Exception("La entidad " + this.Name + " ha perdido todos sus puntos de defensa debido a que ha utilizado un item!!");

                }
            }
        }
        





        /*
        public int attackPoints { 
            get
            {
                if(AttackPoints <= 0)
                {
                    //MessageBox.Show("Esta entidad hay perdido todos sus puntos de ataque :(");
                    return 0;
                }
                else
                {
                    return AttackPoints;
                }  
            }

            set
            {
                
                if (value >= 80)
                {
                    AttackPoints = 80;
                }
                else
                {
                    AttackPoints = value;
                }
                

                /*
                if (value >= 10 && value <= 80)
                {
                     
                    AttackPoints = value;
                }
                else
                    
                AttackPoints = 80;
                    throw new ArgumentOutOfRangeException(nameof(value), "The valid range for attack points is between 10 and 80.");
                
            }
        }
        */

        /*
        public int defensePoints {
            get
            {
                if (DefensePoints <= 0)
                {
                    return 0;
                }
                else
                {
                    return DefensePoints;
                }
            }

            set
            {
                if (value >= 80)
                {
                    DefensePoints = 80;
                }
                else
                {
                    DefensePoints = value;
                }
                /*
                if (value >= 10 && value <= 80)
                {
                    DefensePoints = value;
                }
                else
                    DefensePoints = 80;
                    throw new ArgumentOutOfRangeException(nameof(value), "The valid range for defense points is between 10 and 80.");
                

            }
        }
        */
        public int currentLife
        {
            get
            {
                //if (CurrentLife <= 0)
                //{
                    //return 0;
                //}
                //else
                //{
                    return CurrentLife;
                //}
            }
            set
            {
                if (value <= 0)
                {
                    CurrentLife = 0;
                    
                    //MessageBox.Show("The creature "+ Name +" has died");
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
                else
                {
                    throw new Exception("El rango de ataque solo puede ser 0 o 1");
                    //MessageBox.Show("El ataque solo puede ser 0 o 1");
                    //AttackRange = 1;
                }
                

                

                //else throw new ArgumentOutOfRangeException(nameof(value), "Attack Range can be 0 (zero) or 1 (one)");

            }
        }
        #endregion

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

        public int BeingAttacked(int atkPoints, Entity entity)
        {
            try
            {
                        if (atkPoints < 0)
                        {
                                this.CurrentLife += atkPoints; //como es la entidad atacante usamos los atributos y no el get set
                                if (this.CurrentLife <= 0)
                                {
                                    MessageBox.Show("vida de atacante: " + this.CurrentLife);
                                    return 1;
                                }
                                else
                                {
                                    MessageBox.Show("Ganó " + entity.name + "con sus puntos de defensa!!");
                                    return 0;

                                }
                        }
                        else
                        {
                            if (atkPoints > 0)
                            {
                                entity.currentLife -= atkPoints; //aca al ser al defensa usamos el get set para que valla a la exepcion cuando se muere
                                MessageBox.Show("Ganó " + this.name + "con sus puntos de ataque!!");
                                return 0;
                            }
                        }
                        return 0;     
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return 2;
            }
             
        }


        public bool UsarItem(Entity entity, Item item)
        {
            if (Kingdom.CanInteract(entity, item) == true)
            {
                if (item.Interact(entity) == true)
                {
                    return true; 
                }
                else
                {
                    //MessageBox.Show("La entidad esta muertaaaaaaa en usar item");
                    return false;
                }


                /*
                if (entity.currentLife <= 0)
                {
                    MessageBox.Show("su entidad murio");
                    return false;
                }
                else
                {
                    item.Interact(entity);
                    return true;
                }
                */


                
            }
            else
            {
                new MessageBoxDarkMode("La entidad seleccionada ( "+entity.name+" ) no puede usar este item ya que no coinciden sus reinos!!", "ALERTA", "Ok", Resources.warning, true);
                
                //MessageBox.Show("la entidad seleccionada no puede usar este item");
                return true;
            }
        }

        public void Eat(Entity entity,  Food food)
        {
            //try
            //{
                if (Diet.CanEat(entity, food) == true)
                {
                    food.Interact(entity);
                    //entity.currentEnergy -= 10;
                }
                else
                {
                    throw new Exception("La dieta ( "+entity.diet+" ) de la entidad seleccionada ( "+entity.name+" ) no coincide con el alimento a ingerir");
                    //MessageBox.Show("la entidad seleccionada no puede comer este alimento");
                }

            //}
            //catch (Exception e)
            //{
                //Console.WriteLine(e.ToString());
            //}
            
            
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
