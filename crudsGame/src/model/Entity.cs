using crudsGame.Properties;
using crudsGame.src.interfaces;
using crudsGame.src.model.Foods;
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
    public class Entity
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
                    throw new Exception("La entidad "+this.Name+" ha obtenido lo máximo que puede obtener en energía ( "+this.MaxEnergy+" )");

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

        private Entity Die(Entity entity)
        {
            return entity;
        }
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
                else if (value >= MaxLife)
                {
                    CurrentLife = MaxLife;
                    throw new Exception("La entidad " + this.Name + " ha obtenido lo máximo que puede obtener en vida ( " + this.MaxLife + " )");
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

        public int GetFullAttack()
        {
            this.currentEnergy -= 50;
            int DicePlayerOne = Dice.TrowDice();
            Message.ShowMessageBoxDarkMode(" Player one ha lanzado el dado: +" + DicePlayerOne + "\n " + this.name + " ataca con (" + this.attackPoints + " + " + DicePlayerOne + ")", "ATENCIÓN", "Ok", Resources.moreAttack);
            return this.attackPoints + DicePlayerOne;   
        }

        public int GetFullDefense(Entity entidadAtacada)
        {
            int DicePlayerTwo = Dice.TrowDice();
            Message.ShowMessageBoxDarkMode(" Player two ha lanzado el dado: +" + DicePlayerTwo + "\n " + entidadAtacada.name + " se defenderá con (" + entidadAtacada.defensePoints + " + " + DicePlayerTwo + ")", "ATENCIÓN", "Ok", Resources.moreDefense);
            return entidadAtacada.defensePoints + DicePlayerTwo;

        }


        public int FinallyResolveTheAttack(Entity entidadAtacada)
        {
            try
            {
                int result = GetFullAttack() - GetFullDefense(entidadAtacada);
                Message.ShowMessageBoxDarkMode("RESULADO FINAL DEL ATAQUE: " + result, "ATENCIÓN", "Ok", Resources.info);
                if (result < 0)
                {
                    this.CurrentLife += result;
                    if (this.CurrentLife <= 0)
                    {
                        return 1;
                    }
                    Message.ShowMessageBoxDarkMode("Ganó " + entidadAtacada.name + " con sus puntos de defensa!!", "ATENCIÓN", "Ok", Resources.moreDefense);
                }
                else
                {
                    entidadAtacada.currentLife -= result;
                    Message.ShowMessageBoxDarkMode("Ganó " + this.name + " con sus puntos de ataque!!", "ATENCIÓN", "Ok", Resources.moreAttack);
                }
                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 2;
            }    
        }

        public int Attack(Entity entityPlayerTwo)
        {
            //try
            //{
                this.currentEnergy -= 50;
                int DicePlayerOne = Dice.TrowDice();
                int DicePlayerTwo = Dice.TrowDice();

                new MessageBoxDarkMode(" Player one ha lanzado el dado: +" + DicePlayerOne + "\n " + this.name + " ataca con (" + this.attackPoints + " + " + DicePlayerOne + ") a " + entityPlayerTwo.name, "ATENCIÓN", "Ok", Resources.moreAttack, true);
                //MessageBox.Show(" Player one ha lanzado el dado: +" + DicePlayerOne + "\n " + this.name + " ataca con (" + this.attackPoints + " + " + DicePlayerOne + ") a " + entityPlayerTwo.name);

                new MessageBoxDarkMode(" Player two ha lanzado el dado: +" + DicePlayerTwo + "\n " + entityPlayerTwo.name + " se defenderá con (" + entityPlayerTwo.defensePoints + " + " + DicePlayerTwo + ")", "ATENCIÓN", "Ok", Resources.moreDefense, true);
                //MessageBox.Show(" Player two ha lanzado el dado: +" + DicePlayerTwo + "\n " + entityPlayerTwo.name + " se defenderá con (" + entityPlayerTwo.defensePoints + " + " + DicePlayerTwo +")");

                //MessageBox.Show("puntos de ataque entidad 1 = " + this.attackPoints + " valor dado = " + DicePlayerOne);
                //MessageBox.Show("puntos de defensa entidad 2 = " + entityPlayerTwo.defensePoints + " valor dado = " + DicePlayerTwo);


                //int ataque = this.attackPoints + DicePlayerOne;
                //int defensa = entityPlayerTwo.defensePoints + DicePlayerTwo;
                //MessageBox.Show("puntos de ataque mas dado 1 = " + ataque + " - PUNTOS DE DEFENSA MAS DADO 2 = " + defensa);

                //int result = ataque - defensa;
                new MessageBoxDarkMode("RESULADO FINAL DE ATAQUE: " + ((this.attackPoints + DicePlayerOne) - (entityPlayerTwo.defensePoints + DicePlayerTwo)), "ATENCIÓN", "Ok", Resources.info, true);
                //MessageBox.Show("RESULADO FINAL DE ATAQUE: " + ((this.attackPoints + DicePlayerOne) - (entityPlayerTwo.defensePoints + DicePlayerTwo)));

                return ((this.attackPoints + DicePlayerOne)-(entityPlayerTwo.defensePoints + DicePlayerTwo));
            //return ((this.attackPoints + DicePlayerOne) - entityPlayerTwo.defensePoints + DicePlayerTwo);
            //}
            //catch (Exception e)
            //{
                //Console.Write(e.ToString());
                //return 0;
            //}
            
        }

        public int BeingAttacked(int atkPoints, Entity entityPlayerTwo)
        {
            try
            {
                  if (atkPoints < 0)
                  {
                        //MessageBox.Show("vida actual " + this.currentLife + " + " + atkPoints);
                        //this.currentLife += atkPoints; //como es la entidad atacante usamos los atributos y no el get set
                        //return 0;

                        this.CurrentLife += atkPoints; //como es la entidad atacante usamos los atributos y no el get set
                        if (this.CurrentLife <= 0)
                        {
                            //MessageBox.Show("vida de atacante: " + this.CurrentLife);
                            return 1;
                        }

                    /*if (this.CurrentLife <= 0)
                        {
                            MessageBox.Show("vida de atacante: " + this.CurrentLife);
                            return 1;
                        }
                        else
                        {

                            return 0;

                        }
                        */
                    new MessageBoxDarkMode("Ganó " + entityPlayerTwo.name + " con sus puntos de defensa!!", "ATENCIÓN", "Ok", Resources.moreDefense, true);
                    //MessageBox.Show("Ganó " + entityPlayerTwo.name + "con sus puntos de defensa!!");
                }
                        else
                        {
                            if (atkPoints > 0)
                            {
                                //MessageBox.Show("vida actual de la entidad q se defiende" + entityPlayerTwo.currentLife + " - " + atkPoints);
                                entityPlayerTwo.currentLife -= atkPoints; //aca al ser al defensa usamos el get set para que valla a la exepcion cuando se muere

                                new MessageBoxDarkMode("Ganó " + this.name + " con sus puntos de ataque!!", "ATENCIÓN", "Ok", Resources.moreAttack, true);
                                //MessageBox.Show("Ganó " + this.name + "con sus puntos de ataque!!");
                                //return 0;
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


        public bool UsarItem(Item item)
        {
            if (Kingdom.CanInteract(item))
            {
                item.Interact(this);
                return true;
            }
            else
            {
                new MessageBoxDarkMode("La entidad seleccionada ( "+ this.name+" ) no puede usar este item ya que no coinciden sus reinos!!", "ALERTA", "Ok", Resources.warning, true);             
                //MessageBox.Show("la entidad seleccionada no puede usar este item");
                //return true;
            }
            return false;
        }

        public bool Eat(Food food)
        {
            /*
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
            */

            
                if (Diet.CanEat(food))
                {
                    food.Interact(this);
                    return true;
                    //entity.currentEnergy -= 10;
                }
                else
                {
                    throw new Exception("La dieta ( "+this.diet+" ) de la entidad seleccionada ( "+this.name+" ) no coincide con el alimento a ingerir");
                    //MessageBox.Show("la entidad seleccionada no puede comer este alimento");
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
            /*
            try
            {
                this.currentLife += this.maxLife;
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
            }

            try
            {
                this.currentEnergy += 50;
                new MessageBoxDarkMode(this.name + " ha recuperado la mitad de su energía y su vida completa!!", "ALERTA", "Ok", Resources.check, true);
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
            }




            /*
            this.currentLife += this.maxLife;
            this.currentEnergy += 50; //hay q llamr a los getters xq ya tienen hechas las validaciones  
            */
            }

        

        public bool MoveThrough(ITerrain terrain)
        {
            //try
            //{
                foreach (IEnvironment env in environmentList)
                {
                    //MessageBox.Show("la entidad: " + name + " tiene ambiente UN TIPO DE AMBIENTE: " + env.ToString());
                    /*
                    if (env.GetType() == env.CanMoveThrough(terrain).GetType())
                    {
                        MessageBox.Show("env type: " + env.GetType().ToString() + " _terrain type: " + env.CanMoveThrough(terrain).GetType());
                        return true;
                    }
                    */
                    
                    if (env.CanMoveThrough(terrain) == true)
                    {
                        this.currentEnergy -= 50;//pierde energia al moverse
                        //MessageBox.Show("la entidad: " + name + " se puede mover en: " + terrain.ToString());
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show("la entidad: " + name + " NO se puede mover en: " + terrain.ToString());
                    }
                    


                }
            throw new Exception("La entidad entidad seleccionada ( " + this.name + " ) NO puede moverse sobre "+terrain.ToString() + "!!!");
            //return false;

            //}
            //catch(Exception e)
            //{
                //Console.WriteLine(e.Message);
                //return false;
            //}
            
        }
    }
}
