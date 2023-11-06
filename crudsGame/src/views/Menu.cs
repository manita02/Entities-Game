using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static crudsGame.src.views.MaterialUI;
using MaterialSkin.Controls;
using crudsGame.Properties;
using crudsGame.src.controllers;
using System.Diagnostics;

namespace crudsGame.src.views
{
    public partial class Menu : MaterialForm
    {
        public Menu()
        {
            InitializeComponent();
            LoadMaterial(this);
        }

        private void cRUDEntitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CRUDentity();
            frm.ShowDialog();
        }

        private void cRUDItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CRUDitem();
            frm.ShowDialog();
        }

        private void cRUDFoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CRUDfood();
            frm.ShowDialog();
        }

        private void gENERATEAMAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxDarkMode messageBox = new MessageBoxDarkMode("Esta seguro de generar el mapa?? No podrá volver a crear, editar o eliminar entidades, items y comidas", "ATENCIÓN", "OkCancel", Resources.question);
                if (model.MessageBox.MessageBoxDialogResult(messageBox) == true)
                {
                    Form frm = new MapTest();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ATENCIÓN", "Ok", Resources.error);
            }
            
        }

        private void sEECODEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/manita02/Entities-Game",
                UseShellExecute = true
            };
            Process.Start(psInfo);

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxDarkMode messageBox = new MessageBoxDarkMode("Esta seguro que desea salir??", "Aviso", "OkCancel", Resources.question);
            if (model.MessageBox.MessageBoxDialogResult(messageBox) == true)
            {
                this.Close();
            }


        }

        private void fUNCTIONALITIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://drive.google.com/file/d/1o8hg8Nqz7P3_5GSXhBtr-4U8dZ7K5NyH/view?usp=sharing",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    }
}
