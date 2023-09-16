using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.controllers
{
    internal class ItemController
    {
        private static ItemController? Instance;


        private ItemController() { }

        public static ItemController getInstance()
        {
            if (Instance == null)
            {
                Instance = new ItemController();
            }
            return Instance;
        }


        public IInteractuable CreateItem(string combotext,int id, string name, int value, bool type)
        {
            return ItemCreator.CreateAitem(combotext, id, name, value, type);

        }


        public void AddItem(IInteractuable item, List<IInteractuable> itemList, DataGridView dgvItem)
        {
            /*
            itemList.Add(item); //se carga en la lista
            int x = dgvItem.Rows.Add(); //se carga la tabla
            dgvItem.Rows[x].Cells[0].Value = item.Id;
            dgvItem.Rows[x].Cells[1].Value = item.Name;
            dgvItem.Rows[x].Cells[2].Value = item.Type;
            dgvItem.Rows[x].Cells[3].Value = item.ToString();
            dgvItem.Rows[x].Cells[4].Value = item.Value;
            */
            
        }

        public int UpdateAnEntity(int rows, DataGridView dgvItem, IInteractuable item)
        {
            /*
            dgvItem.Rows[rows].Cells[0].Value = item.Id;
            dgvItem.Rows[rows].Cells[1].Value = item.Name;
            dgvItem.Rows[rows].Cells[2].Value = item.Type;
            dgvItem.Rows[rows].Cells[3].Value = item.ToString();
            dgvItem.Rows[rows].Cells[4].Value = item.Value;
            */
            return rows = 0;
            

        }

        public void DeleteAnEntity(List<IInteractuable> itemList, int r)
        {
            for (int i = 0; i < itemList.Count; i++)
            {
                if (i == r)
                {
                    itemList.RemoveAt(i);
                }
            }
        }
    }
}
