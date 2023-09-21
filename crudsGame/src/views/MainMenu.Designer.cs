namespace crudsGame.src.views
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu1 = new MenuStrip();
            tESTINTERACTIONSToolStripMenuItem = new ToolStripMenuItem();
            cRUDsToolStripMenuItem = new ToolStripMenuItem();
            cRUDEntityToolStripMenuItem = new ToolStripMenuItem();
            cRUDItemToolStripMenuItem = new ToolStripMenuItem();
            cRUDFoodsToolStripMenuItem = new ToolStripMenuItem();
            menu1.SuspendLayout();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.BackColor = Color.Black;
            menu1.Items.AddRange(new ToolStripItem[] { tESTINTERACTIONSToolStripMenuItem, cRUDsToolStripMenuItem });
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(800, 29);
            menu1.TabIndex = 0;
            menu1.Text = "menu";
            // 
            // tESTINTERACTIONSToolStripMenuItem
            // 
            tESTINTERACTIONSToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tESTINTERACTIONSToolStripMenuItem.ForeColor = SystemColors.Control;
            tESTINTERACTIONSToolStripMenuItem.Name = "tESTINTERACTIONSToolStripMenuItem";
            tESTINTERACTIONSToolStripMenuItem.Size = new Size(177, 25);
            tESTINTERACTIONSToolStripMenuItem.Text = "TEST INTERACTIONS";
            tESTINTERACTIONSToolStripMenuItem.Click += tESTINTERACTIONSToolStripMenuItem_Click;
            // 
            // cRUDsToolStripMenuItem
            // 
            cRUDsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cRUDEntityToolStripMenuItem, cRUDItemToolStripMenuItem, cRUDFoodsToolStripMenuItem });
            cRUDsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cRUDsToolStripMenuItem.ForeColor = SystemColors.Control;
            cRUDsToolStripMenuItem.Name = "cRUDsToolStripMenuItem";
            cRUDsToolStripMenuItem.Size = new Size(73, 25);
            cRUDsToolStripMenuItem.Text = "CRUDs";
            // 
            // cRUDEntityToolStripMenuItem
            // 
            cRUDEntityToolStripMenuItem.Name = "cRUDEntityToolStripMenuItem";
            cRUDEntityToolStripMenuItem.Size = new Size(185, 26);
            cRUDEntityToolStripMenuItem.Text = "CRUD entities";
            cRUDEntityToolStripMenuItem.Click += cRUDEntityToolStripMenuItem_Click;
            // 
            // cRUDItemToolStripMenuItem
            // 
            cRUDItemToolStripMenuItem.Name = "cRUDItemToolStripMenuItem";
            cRUDItemToolStripMenuItem.Size = new Size(185, 26);
            cRUDItemToolStripMenuItem.Text = "CRUD items";
            cRUDItemToolStripMenuItem.Click += cRUDItemToolStripMenuItem_Click;
            // 
            // cRUDFoodsToolStripMenuItem
            // 
            cRUDFoodsToolStripMenuItem.Name = "cRUDFoodsToolStripMenuItem";
            cRUDFoodsToolStripMenuItem.Size = new Size(185, 26);
            cRUDFoodsToolStripMenuItem.Text = "CRUD foods";
            cRUDFoodsToolStripMenuItem.Click += cRUDFoodsToolStripMenuItem_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainLogo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menu1);
            MainMenuStrip = menu1;
            Name = "MainMenu";
            Text = "MainMenu";
            menu1.ResumeLayout(false);
            menu1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu1;
        private ToolStripMenuItem tESTINTERACTIONSToolStripMenuItem;
        private ToolStripMenuItem cRUDsToolStripMenuItem;
        private ToolStripMenuItem cRUDEntityToolStripMenuItem;
        private ToolStripMenuItem cRUDItemToolStripMenuItem;
        private ToolStripMenuItem cRUDFoodsToolStripMenuItem;
    }
}