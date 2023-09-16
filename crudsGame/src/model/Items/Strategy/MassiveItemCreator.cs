using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model.Items.Strategy
{
    static class MassiveItemCreator
    {
        //List<String> nombresPos=new List<String>();

        //List<String> nombresNegativos = new List<String>();

        public static void asd()
        {
            var namesPos = new List<string> { "Saliva Divina", "Furia de Preyton", "Poción de Bravura", "Poción de Fortaleza", "Néctar Calmante de Esmeralda" };
            var namesNeg = new List<string> { "Pócima de Donosura", "Ácido de Troll", "Elixir de la Condenación", "Esencia del Caos", "Licor de Tzeentch" };
            foreach (var name in namesPos)
            {
                MessageBox.Show($"Hello {name.ToUpper()}!");
                //Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
        
    }
}
