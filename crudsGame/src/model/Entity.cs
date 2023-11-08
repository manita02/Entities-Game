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
        private int CheckIfTheAttackingEntityDied()
        {
            if (this.CurrentLife <= 0)
            {
                return 1;
            }
            return 0;
        }

        public int Attack(Entity entityToAttack)
        {
            try
            {
                this.currentEnergy -= 50;
                int fullAttack = this.attackPoints + Dice.TrowDice();
                MessageBox.Show("La entidad atacante " + this.name + " ataca con: " + fullAttack, "Aviso", "Ok", Resources.moreAttack);
                int finalResultOfAttack = entityToAttack.ReceiveAttack(fullAttack);//la entidad que recibe el ataque se le pasa la entidad atacada
                if (finalResultOfAttack != 0)
                {
                    this.CurrentLife -= finalResultOfAttack;
                    return CheckIfTheAttackingEntityDied();
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 2;
            }
            
        }
        public int ReceiveAttack(int fullAttack)
        {
            int finalResultOfAttack = 0;
            if (CompareAttackPointsWithMyDefense(fullAttack))
            {
                MessageBox.Show("La entidad que se defiende ("+this.name+") pierde, por lo tanto perderá esto de vida: -"+fullAttack, "Ganó la entidad atacante", "Ok", Resources.moreAttack);
                currentLife -= fullAttack;
            }
            else 
            {
                finalResultOfAttack = this.defensePoints - fullAttack;
                MessageBox.Show("La entidad que ataca ("+this.name+") pierde, por lo tanto perderá esto de vida: (" + this.defensePoints +" - " + fullAttack + ") = "+ finalResultOfAttack, "Ganó la entidad que se defiende", "Ok", Resources.moreDefense);      
            }
            //MessageBox.Show("valor final del resultado q se va a restar a la entidad atacante: "+finalResultOfAttack,"info del resultado", "Ok", Resources.info);
            return finalResultOfAttack;
        }
        public bool CompareAttackPointsWithMyDefense(int fullAttack)
        {
            int fullDefense = this.defensePoints + Dice.TrowDice();
            MessageBox.Show("La entidad que se defiende: " + this.name + " se va a defender con: " + fullDefense, "Aviso", "Ok", Resources.moreDefense);
            return (fullAttack > fullDefense); //devuelve true si los puntos de ataque son mayores a los de la defensa --> se le debe restar a la entidad atacada
        }
        #endregion


        public bool UseItem(Item item)
        {
            if (Kingdom.CanInteract(item))
            {
                if (item.Interact(this))
                {
                    return true;
                }
                else
                {
                    return false;
                }            
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
                if (food.Interact(this))
                {
                    return true;
                }
                else
                {
                    return false;
                }    
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
