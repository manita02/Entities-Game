using crudsGame.Properties;
using crudsGame.src.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model
{
    static class MessageBox
    {
        public static MessageBoxDarkMode Show(string message,string title,string type, Image img)
        {
            return new MessageBoxDarkMode(message, title, type, img, true);

        }
    }
}
