using crudsGame.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model
{
    static class Dice
    {
        static Random RandomSide = new Random();
        public static int TrowDice()
        {
            return RandomSide.Next(1, 6);
        }

        public static int ShowThrowOfTheDice(int entity)
        {
            int diceValue = 0;
            if (entity == 1) 
            {
                diceValue = TrowDice();
                MessageBox.Show("La entidad atacante a lanzado el dado y obtuvo un +" + diceValue+ " --> estos se sumarán a sus puntos de ataque", "Aviso", "Ok", Resources.info);
            }
            else
            {
                diceValue = TrowDice();
                MessageBox.Show("La entidad que se defiende a lanzado tambien el dado y obtuvo un +" + diceValue + " --> estos se sumarán a sus puntos de defensa", "Aviso", "Ok", Resources.info);
            }

            return diceValue;
        }
    }
}
