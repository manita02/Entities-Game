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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            asdasdToolStripMenuItem = new ToolStripMenuItem();
            menu1 = new MenuStrip();
            tESTINTERACTIONSToolStripMenuItem = new ToolStripMenuItem();
            cRUDsToolStripMenuItem = new ToolStripMenuItem();
            cRUDEntityToolStripMenuItem = new ToolStripMenuItem();
            cRUDItemToolStripMenuItem = new ToolStripMenuItem();
            cRUDFoodsToolStripMenuItem = new ToolStripMenuItem();
            mAPTESTToolStripMenuItem = new ToolStripMenuItem();
            btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            materialContextMenuStrip1.SuspendLayout();
            menu1.SuspendLayout();
            SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            materialContextMenuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            materialContextMenuStrip1.Depth = 0;
            materialContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            materialContextMenuStrip1.Items.AddRange(new ToolStripItem[] { asdasdToolStripMenuItem });
            materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            materialContextMenuStrip1.Size = new Size(141, 36);
            // 
            // asdasdToolStripMenuItem
            // 
            asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            asdasdToolStripMenuItem.Size = new Size(140, 32);
            asdasdToolStripMenuItem.Text = "asdasd";
            // 
            // menu1
            // 
            menu1.BackColor = Color.Black;
            menu1.ImageScalingSize = new Size(24, 24);
            menu1.Items.AddRange(new ToolStripItem[] { tESTINTERACTIONSToolStripMenuItem, cRUDsToolStripMenuItem, mAPTESTToolStripMenuItem });
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Padding = new Padding(9, 3, 0, 3);
            menu1.Size = new Size(1587, 42);
            menu1.TabIndex = 1;
            menu1.Text = "menu";
            // 
            // tESTINTERACTIONSToolStripMenuItem
            // 
            tESTINTERACTIONSToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tESTINTERACTIONSToolStripMenuItem.ForeColor = SystemColors.Control;
            tESTINTERACTIONSToolStripMenuItem.Name = "tESTINTERACTIONSToolStripMenuItem";
            tESTINTERACTIONSToolStripMenuItem.Size = new Size(265, 36);
            tESTINTERACTIONSToolStripMenuItem.Text = "TEST INTERACTIONS";
            tESTINTERACTIONSToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            tESTINTERACTIONSToolStripMenuItem.Click += tESTINTERACTIONSToolStripMenuItem_Click_1;
            // 
            // cRUDsToolStripMenuItem
            // 
            cRUDsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cRUDEntityToolStripMenuItem, cRUDItemToolStripMenuItem, cRUDFoodsToolStripMenuItem });
            cRUDsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cRUDsToolStripMenuItem.ForeColor = SystemColors.Control;
            cRUDsToolStripMenuItem.Name = "cRUDsToolStripMenuItem";
            cRUDsToolStripMenuItem.Size = new Size(107, 36);
            cRUDsToolStripMenuItem.Text = "CRUDs";
            // 
            // cRUDEntityToolStripMenuItem
            // 
            cRUDEntityToolStripMenuItem.Name = "cRUDEntityToolStripMenuItem";
            cRUDEntityToolStripMenuItem.Size = new Size(275, 40);
            cRUDEntityToolStripMenuItem.Text = "CRUD entities";
            cRUDEntityToolStripMenuItem.Click += cRUDEntityToolStripMenuItem_Click_1;
            // 
            // cRUDItemToolStripMenuItem
            // 
            cRUDItemToolStripMenuItem.Name = "cRUDItemToolStripMenuItem";
            cRUDItemToolStripMenuItem.Size = new Size(275, 40);
            cRUDItemToolStripMenuItem.Text = "CRUD items";
            cRUDItemToolStripMenuItem.Click += cRUDItemToolStripMenuItem_Click_1;
            // 
            // cRUDFoodsToolStripMenuItem
            // 
            cRUDFoodsToolStripMenuItem.Name = "cRUDFoodsToolStripMenuItem";
            cRUDFoodsToolStripMenuItem.Size = new Size(275, 40);
            cRUDFoodsToolStripMenuItem.Text = "CRUD foods";
            cRUDFoodsToolStripMenuItem.Click += cRUDFoodsToolStripMenuItem_Click_1;
            // 
            // mAPTESTToolStripMenuItem
            // 
            mAPTESTToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mAPTESTToolStripMenuItem.ForeColor = SystemColors.Control;
            mAPTESTToolStripMenuItem.Name = "mAPTESTToolStripMenuItem";
            mAPTESTToolStripMenuItem.Size = new Size(146, 36);
            mAPTESTToolStripMenuItem.Text = "MAP TEST";
            mAPTESTToolStripMenuItem.Click += mAPTESTToolStripMenuItem_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.Depth = 0;
            btnExit.Icon = null;
            btnExit.Location = new Point(17, 960);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.Primary = true;
            btnExit.Size = new Size(66, 36);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1587, 1040);
            Controls.Add(btnExit);
            Controls.Add(menu1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            materialContextMenuStrip1.ResumeLayout(false);
            menu1.ResumeLayout(false);
            menu1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private ToolStripMenuItem asdasdToolStripMenuItem;
        private MenuStrip menu1;
        private ToolStripMenuItem tESTINTERACTIONSToolStripMenuItem;
        private ToolStripMenuItem cRUDsToolStripMenuItem;
        private ToolStripMenuItem cRUDEntityToolStripMenuItem;
        private ToolStripMenuItem cRUDItemToolStripMenuItem;
        private ToolStripMenuItem cRUDFoodsToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private ToolStripMenuItem mAPTESTToolStripMenuItem;
    }
}