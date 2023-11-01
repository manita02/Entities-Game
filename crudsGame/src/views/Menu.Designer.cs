namespace crudsGame.src.views
{
    partial class Menu
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
            materialMenuStrip1 = new MaterialSkin.Controls.MaterialMenuStrip();
            cRUDsToolStripMenuItem = new ToolStripMenuItem();
            cRUDEntitiesToolStripMenuItem = new ToolStripMenuItem();
            cRUDItemsToolStripMenuItem = new ToolStripMenuItem();
            cRUDFoodsToolStripMenuItem = new ToolStripMenuItem();
            gENERATEAMAPToolStripMenuItem = new ToolStripMenuItem();
            fUNCTIONALITIESToolStripMenuItem = new ToolStripMenuItem();
            sEECODEToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            materialMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialMenuStrip1
            // 
            materialMenuStrip1.BackColor = Color.FromArgb(55, 71, 79);
            materialMenuStrip1.Depth = 0;
            materialMenuStrip1.Dock = DockStyle.Left;
            materialMenuStrip1.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            materialMenuStrip1.ImageScalingSize = new Size(24, 24);
            materialMenuStrip1.Items.AddRange(new ToolStripItem[] { cRUDsToolStripMenuItem, gENERATEAMAPToolStripMenuItem, fUNCTIONALITIESToolStripMenuItem, sEECODEToolStripMenuItem, eXITToolStripMenuItem });
            materialMenuStrip1.Location = new Point(0, 0);
            materialMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMenuStrip1.Name = "materialMenuStrip1";
            materialMenuStrip1.Padding = new Padding(6, 60, 0, 2);
            materialMenuStrip1.Size = new Size(177, 644);
            materialMenuStrip1.TabIndex = 0;
            materialMenuStrip1.Text = "materialMenuStrip1";
            // 
            // cRUDsToolStripMenuItem
            // 
            cRUDsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cRUDEntitiesToolStripMenuItem, cRUDItemsToolStripMenuItem, cRUDFoodsToolStripMenuItem });
            cRUDsToolStripMenuItem.Name = "cRUDsToolStripMenuItem";
            cRUDsToolStripMenuItem.Padding = new Padding(6, 20, 6, 0);
            cRUDsToolStripMenuItem.Size = new Size(164, 49);
            cRUDsToolStripMenuItem.Text = "CRUDs";
            // 
            // cRUDEntitiesToolStripMenuItem
            // 
            cRUDEntitiesToolStripMenuItem.Name = "cRUDEntitiesToolStripMenuItem";
            cRUDEntitiesToolStripMenuItem.Size = new Size(237, 34);
            cRUDEntitiesToolStripMenuItem.Text = "CRUD entities";
            cRUDEntitiesToolStripMenuItem.Click += cRUDEntitiesToolStripMenuItem_Click;
            // 
            // cRUDItemsToolStripMenuItem
            // 
            cRUDItemsToolStripMenuItem.Name = "cRUDItemsToolStripMenuItem";
            cRUDItemsToolStripMenuItem.Size = new Size(237, 34);
            cRUDItemsToolStripMenuItem.Text = "CRUD items";
            cRUDItemsToolStripMenuItem.Click += cRUDItemsToolStripMenuItem_Click;
            // 
            // cRUDFoodsToolStripMenuItem
            // 
            cRUDFoodsToolStripMenuItem.Name = "cRUDFoodsToolStripMenuItem";
            cRUDFoodsToolStripMenuItem.Size = new Size(237, 34);
            cRUDFoodsToolStripMenuItem.Text = "CRUD foods";
            cRUDFoodsToolStripMenuItem.Click += cRUDFoodsToolStripMenuItem_Click;
            // 
            // gENERATEAMAPToolStripMenuItem
            // 
            gENERATEAMAPToolStripMenuItem.Name = "gENERATEAMAPToolStripMenuItem";
            gENERATEAMAPToolStripMenuItem.Padding = new Padding(6, 20, 6, 0);
            gENERATEAMAPToolStripMenuItem.Size = new Size(164, 49);
            gENERATEAMAPToolStripMenuItem.Text = "Generate a Map";
            gENERATEAMAPToolStripMenuItem.Click += gENERATEAMAPToolStripMenuItem_Click;
            // 
            // fUNCTIONALITIESToolStripMenuItem
            // 
            fUNCTIONALITIESToolStripMenuItem.Name = "fUNCTIONALITIESToolStripMenuItem";
            fUNCTIONALITIESToolStripMenuItem.Padding = new Padding(6, 20, 6, 0);
            fUNCTIONALITIESToolStripMenuItem.Size = new Size(164, 49);
            fUNCTIONALITIESToolStripMenuItem.Text = "Functionalities";
            // 
            // sEECODEToolStripMenuItem
            // 
            sEECODEToolStripMenuItem.Name = "sEECODEToolStripMenuItem";
            sEECODEToolStripMenuItem.Padding = new Padding(6, 20, 6, 0);
            sEECODEToolStripMenuItem.Size = new Size(164, 49);
            sEECODEToolStripMenuItem.Text = "See Code";
            sEECODEToolStripMenuItem.Click += sEECODEToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Padding = new Padding(6, 20, 6, 0);
            eXITToolStripMenuItem.Size = new Size(164, 49);
            eXITToolStripMenuItem.Text = "Exit";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu;
            pictureBox1.Location = new Point(245, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(595, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(283, 64);
            label1.Name = "label1";
            label1.Size = new Size(485, 54);
            label1.TabIndex = 5;
            label1.Text = "👺👾Entities Game👽👹";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(402, 602);
            label2.Name = "label2";
            label2.Size = new Size(275, 20);
            label2.TabIndex = 6;
            label2.Text = "© copyright 2023 - Miramar, Argentina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(429, 622);
            label3.Name = "label3";
            label3.Size = new Size(232, 20);
            label3.TabIndex = 7;
            label3.Text = "Developed by Ana Lucia Juarez";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 644);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(materialMenuStrip1);
            MainMenuStrip = materialMenuStrip1;
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            materialMenuStrip1.ResumeLayout(false);
            materialMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMenuStrip materialMenuStrip1;
        private ToolStripMenuItem cRUDsToolStripMenuItem;
        private ToolStripMenuItem cRUDEntitiesToolStripMenuItem;
        private ToolStripMenuItem cRUDItemsToolStripMenuItem;
        private ToolStripMenuItem cRUDFoodsToolStripMenuItem;
        private ToolStripMenuItem gENERATEAMAPToolStripMenuItem;
        private ToolStripMenuItem fUNCTIONALITIESToolStripMenuItem;
        private ToolStripMenuItem sEECODEToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}