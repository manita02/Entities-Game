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
            kingdom = kingdomm; 
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

        #region Properties

        public List<IEnvironment> environmentList
        {
            get
            {
                return EnvironmentsList;            
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
                }
            }
        }
        #endregion

        #region Attack
        public int GetFullAttack()
        {
            this.currentEnergy -= 50;
            int DicePlayerOne = Dice.TrowDice();
            MessageBox.Show(" Player one ha lanzado el dado: +" + DicePlayerOne + "\n " + this.name + " ataca con (" + this.attackPoints + " + " + DicePlayerOne + ")", "ATENCIÓN", "Ok", Resources.moreAttack);
            return this.attackPoints + DicePlayerOne;   
        }

        public int GetFullDefense(Entity entidadAtacada)
        {
            int DicePlayerTwo = Dice.TrowDice();
            MessageBox.Show(" Player two ha lanzado el dado: +" + DicePlayerTwo + "\n " + entidadAtacada.name + " se defenderá con (" + entidadAtacada.defensePoints + " + " + DicePlayerTwo + ")", "ATENCIÓN", "Ok", Resources.moreDefense);
            return entidadAtacada.defensePoints + DicePlayerTwo;

        }


        public int FinallyResolveTheAttack(Entity entidadAtacada)
        {
            try
            {
                int result = GetFullAttack() - GetFullDefense(entidadAtacada);
                MessageBox.Show("RESULADO FINAL DEL ATAQUE: " + result, "ATENCIÓN", "Ok", Resources.info);
                if (result < 0)
                {
                    this.CurrentLife += result;
                    if (this.CurrentLife <= 0)
                    {
                        return 1;
                    }
                    MessageBox.Show("Ganó " + entidadAtacada.name + " con sus puntos de defensa!!", "ATENCIÓN", "Ok", Resources.moreDefense);
                }
                else
                {
                    entidadAtacada.currentLife -= result;
                    MessageBox.Show("Ganó " + this.name + " con sus puntos de ataque!!", "ATENCIÓN", "Ok", Resources.moreAttack);
                }
                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 2;
            }    
        }
        #endregion


        public bool UseItem(Item item)
        {
            if (Kingdom.CanInteract(item))
            {
                item.Interact(this);
                return true;
            }
            else
            {
                MessageBox.Show("La entidad seleccionada ( "+ this.name+" ) no puede usar este item ya que no coinciden sus reinos!!", "ALERTA", "Ok", Resources.warning);             
            }
            return false;
        }

        public bool Eat(Food food)
        {
            if (Diet.CanEat(food))
            {
                food.Interact(this);
                return true;
            }
            else
            {
                throw new Exception("La dieta ( "+this.diet+" ) de la entidad seleccionada ( "+this.name+" ) no coincide con el alimento a ingerir");
            }
        }

        public bool MoveThrough(ITerrain terrain)
        {
            foreach (IEnvironment env in environmentList)
            {
                if (env.CanMoveThrough(terrain) == true)
                {
                    this.currentEnergy -= 50;
                    return true;
                }
            }
            throw new Exception("La entidad entidad seleccionada ( " + this.name + " ) NO puede moverse sobre "+terrain.ToString() + "!!!"); 
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
