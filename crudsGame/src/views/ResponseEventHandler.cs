using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.views
{
    public class ResponseEventHandler : EventArgs
    {
        public bool status { get; set; }

        public ResponseEventHandler() { }

        public ResponseEventHandler(bool @checked)
        {
            status = @checked;
        }
    }
}
