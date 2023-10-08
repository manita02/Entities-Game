using crudsGame.Properties;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
using crudsGame.src.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crudsGame.src.controllers
{
    static class GeneralController
    {
        /*
        public static IInteractuable CreateItem(string seleccionCombo, int txtId, string txtName, int txtValue) //me sirve pa los dos tipos de items
        {

            return ItemCreator.CreateAitem(seleccionCombo, txtId, txtName, txtValue);

        }
        

        

        public static void PreventEditingInCombobox(ComboBox combobox)
        {
            combobox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        */
        public static void ValidateNumbers(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                new MessageBoxDarkMode("Only numbers can be entered", "ALERT", "Ok", Resources.warning, true);
                e.Handled = true;
                return;
            }
            else
            {
                if(e.KeyChar == 48)
                {
                    new MessageBoxDarkMode("No puede ingresar el valor cero en este campo", "ALERT", "Ok", Resources.warning, true);
                    e.Handled = true;
                    return;
                }
            }
        }

        /*
        public static void cargarDietasEnCombo(List<IDiet> dietList, ComboBox cbDiet)
        {
            PreventEditingInCombobox(cbDiet);

            dietList.Add(DietCreator.CreateAdiet(1));
            dietList.Add(DietCreator.CreateAdiet(2));
            dietList.Add(DietCreator.CreateAdiet(3));
            dietList.Add(DietCreator.CreateAdiet(4));

            foreach (var diet in dietList)
            {
                cbDiet.Items.Add(diet);
            }

            cbDiet.SelectedIndex = 0;
        }

        public static void cargarAmbientesEnCombo(List<IEnvironment> environmentsList, ComboBox cbEnvironment)
        {
            PreventEditingInCombobox(cbEnvironment);

            environmentsList.Add(EnvironmentCreator.CreateAenvironment(1));
            environmentsList.Add(EnvironmentCreator.CreateAenvironment(2));
            environmentsList.Add(EnvironmentCreator.CreateAenvironment(3));

            foreach (var environment in environmentsList)
            {
                cbEnvironment.Items.Add(environment);
            }

            cbEnvironment.SelectedIndex = 0;
        }

        public static void cargarReinosEnCombo(List<IKingdom> kingdomsList, ComboBox cbKingdom)
        {
            PreventEditingInCombobox(cbKingdom); 

            kingdomsList.Add(KingdomCreator.CreateAkingdom(1));
            kingdomsList.Add(KingdomCreator.CreateAkingdom(2));
            kingdomsList.Add(KingdomCreator.CreateAkingdom(3));
            kingdomsList.Add(KingdomCreator.CreateAkingdom(4));

            foreach (var kingdom in kingdomsList)
            {
                cbKingdom.Items.Add(kingdom);
            }

            cbKingdom.SelectedIndex = 0;
        }

        public static void cargarTiposDeItemsEnCombo(List<IInteractuable> itemList, ComboBox cbItem)
        {
            PreventEditingInCombobox(cbItem);

            cbItem.Items.Add("Affects energy");
            cbItem.Items.Add("Affects life");

            /*
            itemList.Add(DietCreator.CreateAdiet(2));
            itemList.Add(DietCreator.CreateAdiet(3));
            dietList.Add(DietCreator.CreateAdiet(4));
            

            foreach (var item in itemList)
            {
                cbItem.Items.Add(item);
            }

            cbItem.SelectedIndex = 0;
        }
        
        public static int LookForTheIndexOfTheComboboxOfItemsThatComesFromTheDatagrid(List<IInteractuable> itemList, DataGridView dgvItems)
        {
            switch (dgvItems.CurrentRow.Cells[3].Value.ToString())
            {
                case "Affects energy":
                    return 0;

                case "Affects life":
                    return 1;


                default: return -1;
            }
        
            
            foreach (var item in itemList)
            {
                
                if (item.ToString() == dgvItems.CurrentRow.Cells[3].Value.ToString())
                {
                    //MessageBox.Show("valor en datagrid: " + dgvItems.CurrentRow.Cells[3].Value.ToString());
                    MessageBox.Show("index en data grid: " + itemList.IndexOf(item));
                    return itemList.IndexOf(item);
                }
            }
            return -1;
            
        }


        
        public static int LookForTheIndexOfTheComboboxOfKingdomsThatComesFromTheDatagrid(List<IKingdom> kingdomList,DataGridView dgvEntities)
        {
            foreach (var kin in kingdomList)
            {
                if (kin.ToString() == dgvEntities.CurrentRow.Cells[1].Value.ToString())
                {
                    return kingdomList.IndexOf(kin);                   
                }
            }
            return -1;
        }


        public static int LookForTheIndexOfTheComboboxOfDietsThatComesFromTheDatagrid(List<IDiet> dietList, DataGridView dgvEntities)
        {
            foreach (var diet in dietList)
            {
                if (diet.ToString() == dgvEntities.CurrentRow.Cells[3].Value.ToString())
                {
                    return dietList.IndexOf(diet);
                }
            }
            return -1;
        }


        public static int LookForTheIndexOfTheComboboxOfEnvironmentsThatComesFromTheDatagrid(List<IEnvironment> environmentList, DataGridView dgvEntities)
        {
            foreach (var env in environmentList)
            {
                if (env.ToString() == dgvEntities.CurrentRow.Cells[4].Value.ToString())
                {
                    return environmentList.IndexOf(env);
                }
            }
            return -1;
        }
        







        
        public static void cargarCombobox(List<IDiet> dietList,ComboBox cbDiet, List<IKingdom> kingdomList, ComboBox cbKingdom, List<IEnvironment> environmentList, ComboBox cbEnvironment)
        {
            foreach (var diet in dietList)
            {
                cbDiet.Items.Add(diet);
            }

            foreach (var kingdom in kingdomList)
            {
                cbKingdom.Items.Add(kingdom);
            }

            foreach (var environment in environmentList)
            {
                cbEnvironment.Items.Add(environment);
            }


        }
        */
    }
}
