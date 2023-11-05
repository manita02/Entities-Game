using crudsGame.Properties;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
using crudsGame.src.views;
using MaterialSkin.Controls;
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
        public static bool MessageBoxDialogResult(MessageBoxDarkMode messageBoxDarkMode)
        {
            bool messageBoxResponse = false;
            messageBoxDarkMode.ResponseEvent += (sender, e) =>
            {
                messageBoxResponse = e.status;
            };
            messageBoxDarkMode.ShowDialog();
            return messageBoxResponse;
        }
        
        public static int CheckThatTheFieldIsNotNull(MaterialSingleLineTextField txt)
        {
            if (txt.Text != "")
            {
                if (Convert.ToInt16(txt.Text) != 0)
                {
                    return Convert.ToInt16(txt.Text);
                }
                else
                {
                    throw new Exception("No puede ingresar el número cero en el campo " + txt.Name + " !!");
                }

            }
            else
            {
                throw new Exception("El campo " + txt.Name + " NO puede estar vacío!!");
            }
        }

        public static void ValidateNumbers(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                new MessageBoxDarkMode("Only numbers can be entered", "ALERT", "Ok", Resources.warning, true);
                e.Handled = true;
                return;
            }
        }

    }
}
