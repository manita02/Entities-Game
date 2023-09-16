using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.controllers.ItemsCtn
{
    internal class PositiveItemController
    {
        private static PositiveItemController? Instance; //seguir con esto hacer crud de items y probar si anda el factory.. cargar las cosas en despues en otro frm en un combo los items
        //List<IEntity> entityList;

        private PositiveItemController() { }

        public static PositiveItemController getInstance()
        {
            if (Instance == null)
            {
                Instance = new PositiveItemController();
            }
            return Instance;
        }
        
        /*
        public void AddPositiveItem(IInteractuable item, List<IInteractuable> itemList, DataGridView dgvItems) 
        {
            itemList.Add(item); //se carga en la lista
            int x = dgvItems.Rows.Add(); //se carga la tabla
            dgvItems.Rows[x].Cells[0].Value = item.GetId();
            dgvItems.Rows[x].Cells[1].Value = item.GetItemName();
            dgvItems.Rows[x].Cells[2].Value = item.GetValue();
            dgvItems.Rows[x].Cells[3].Value = "Positive (+ energy)"; 
        }

        
        public int editando(int rows, DataGridView dgvItems, IInteractuable item)
        {
            dgvItems.Rows[rows].Cells[0].Value = item.GetId();
            dgvItems.Rows[rows].Cells[1].Value = item.GetItemName();
            dgvItems.Rows[rows].Cells[2].Value = item.GetValue();
            dgvItems.Rows[rows].Cells[3].Value = "Positive (+ energy)";

            return rows = 0;

        }
        
       */

        
    }
}
