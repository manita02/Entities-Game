using crudsGame.src.controllers;
using static crudsGame.src.views.MaterialUI;
using MaterialSkin.Controls;

namespace crudsGame
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            LoadMaterial(this);
            ItemController entityCtn;
            entityCtn = ItemController.getInstance();

        }
        private ComboBox comboBox1;



        private void InitializeComponent()
        {
            materialMenuStrip1 = new MaterialMenuStrip();
            asdasdasToolStripMenuItem = new ToolStripMenuItem();
            asdasdasdToolStripMenuItem = new ToolStripMenuItem();
            adsaToolStripMenuItem = new ToolStripMenuItem();
            asdasdToolStripMenuItem = new ToolStripMenuItem();
            materialMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // materialMenuStrip1
            // 
            materialMenuStrip1.BackColor = Color.FromArgb(55, 71, 79);
            materialMenuStrip1.Depth = 0;
            materialMenuStrip1.Dock = DockStyle.Left;
            materialMenuStrip1.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            materialMenuStrip1.ImageScalingSize = new Size(24, 24);
            materialMenuStrip1.Items.AddRange(new ToolStripItem[] { asdasdasToolStripMenuItem, asdasdasdToolStripMenuItem, adsaToolStripMenuItem });
            materialMenuStrip1.Location = new Point(0, 0);
            materialMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMenuStrip1.Name = "materialMenuStrip1";
            materialMenuStrip1.RenderMode = ToolStripRenderMode.System;
            materialMenuStrip1.Size = new Size(130, 404);
            materialMenuStrip1.TabIndex = 0;
            materialMenuStrip1.Text = "materialMenuStrip1";
            // 
            // asdasdasToolStripMenuItem
            // 
            asdasdasToolStripMenuItem.Name = "asdasdasToolStripMenuItem";
            asdasdasToolStripMenuItem.Size = new Size(113, 29);
            asdasdasToolStripMenuItem.Text = "asdasdas";
            // 
            // asdasdasdToolStripMenuItem
            // 
            asdasdasdToolStripMenuItem.Name = "asdasdasdToolStripMenuItem";
            asdasdasdToolStripMenuItem.Size = new Size(124, 29);
            asdasdasdToolStripMenuItem.Text = "asdasdasd";
            // 
            // adsaToolStripMenuItem
            // 
            adsaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asdasdToolStripMenuItem });
            adsaToolStripMenuItem.Name = "adsaToolStripMenuItem";
            adsaToolStripMenuItem.Size = new Size(71, 29);
            adsaToolStripMenuItem.Text = "adsa";
            // 
            // asdasdToolStripMenuItem
            // 
            asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            asdasdToolStripMenuItem.Size = new Size(178, 34);
            asdasdToolStripMenuItem.Text = "asdasd";
            // 
            // Form1
            // 
            ClientSize = new Size(616, 404);
            Controls.Add(materialMenuStrip1);
            MainMenuStrip = materialMenuStrip1;
            Name = "Form1";
            materialMenuStrip1.ResumeLayout(false);
            materialMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialMenuStrip materialMenuStrip1;
        private ToolStripMenuItem asdasdasToolStripMenuItem;
        private ToolStripMenuItem asdasdasdToolStripMenuItem;
        private ToolStripMenuItem adsaToolStripMenuItem;
        private ToolStripMenuItem asdasdToolStripMenuItem;
    }
}