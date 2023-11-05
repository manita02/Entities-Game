using crudsGame.Properties;
using crudsGame.src.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.model
{
    static class Message
    {
        public static MessageBoxDarkMode ShowMessageBoxDarkMode(string message,string title,string type, Image img)
        {
            return new MessageBoxDarkMode(message, title, type, img, true);

        }
    }
}
