using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace crudsGame.src.views
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void tESTINTERACTIONSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new AttackTest();
            frm.ShowDialog();
        }

        private void cRUDEntityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new CRUDentity();
            frm.ShowDialog();
        }

        private void cRUDItemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new CRUDitem();
            frm.ShowDialog();
        }

        private void cRUDFoodsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new CRUDfood();
            frm.ShowDialog();
        }
    }
}
