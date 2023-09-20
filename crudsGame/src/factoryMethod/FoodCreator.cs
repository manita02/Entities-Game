using crudsGame.src.interfaces;
using crudsGame.src.model;
using crudsGame.src.model.Diets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.factoryMethod
{
    public class FoodCreator
    {
        public static Food CreateAfood(string seleccionDelCombo)
        {
            switch (seleccionDelCombo)
            {
                case "Animal":
                    //return new AnimalFood(); //estos metodos de crear cada cosa abria que llamarlos desde cada controladora
                case "Vegetable":
                    //return new VegetableFood();
                case "Energy":
                    //return new Energy();
                default: return null;
            }
        }
    }
}
