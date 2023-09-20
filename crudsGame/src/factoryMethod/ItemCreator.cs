using crudsGame.src.controllers.ItemsCtn;
using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crudsGame.src.factoryMethod
{
    public class ItemCreator
    {
        
        public static Item CreateAitem(string seleccionDelCombo, int txtId, string txtName, int txtValue, bool type)
        {
            switch (seleccionDelCombo)
            {
                case "Affects energy":
                    //return new EnergyItem(txtId, txtName, txtValue, type);
                
                case "Affects life":
                    //return new LifeItem(txtId, txtName, txtValue,type);
                
                    
                default: return null;
            }
        }
        
    }
}
