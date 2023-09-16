using crudsGame.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.controllers.ItemsCtn
{
    internal class NegativeItemController
    {
        private static NegativeItemController? Instance; 
        

        private NegativeItemController() { }

        public static NegativeItemController getInstance()
        {
            if (Instance == null)
            {
                Instance = new NegativeItemController();
            }
            return Instance;
        }

    /*
        public void AddNegativeItem(IInteractuable item, List<IInteractuable> itemList, DataGridView dgvItems)
        {
            itemList.Add(item); //se carga en la lista
            int x = dgvItems.Rows.Add(); //se carga la tabla
            dgvItems.Rows[x].Cells[0].Value = item.GetId();
            dgvItems.Rows[x].Cells[1].Value = item.GetItemName();
            dgvItems.Rows[x].Cells[2].Value = item.GetValue();
            dgvItems.Rows[x].Cells[3].Value = "Negative (- energy)"; 
        }

        public int editandoNegativos(int rows, DataGridView dgvItems, IInteractuable item)
        {
            dgvItems.Rows[rows].Cells[0].Value = item.GetId();
            dgvItems.Rows[rows].Cells[1].Value = item.GetItemName();
            dgvItems.Rows[rows].Cells[2].Value = item.GetValue();
            dgvItems.Rows[rows].Cells[3].Value = "Negative (- energy)";

            return rows = 0;

        }
    */
    }

}
