﻿using crudsGame.Properties;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model.Items;
using crudsGame.src.views;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crudsGame.src.controllers
{
    static class GeneralController
    {
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

        public static void PlaySoundEffect(UnmanagedMemoryStream effect)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
            sound.Stream = effect;
            sound.Play();
        }

    }
}
