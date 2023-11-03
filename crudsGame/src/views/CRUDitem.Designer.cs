namespace crudsGame.src.views
{
    partial class CRUDitem
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDitem));
            dgvItems = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            cbType = new ComboBox();
            cbKingdom = new ComboBox();
            picItem = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            btnCreatee = new MaterialSkin.Controls.MaterialRaisedButton();
            btnUpdatee = new MaterialSkin.Controls.MaterialRaisedButton();
            btnDeletee = new MaterialSkin.Controls.MaterialRaisedButton();
            txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picItem).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.BorderStyle = BorderStyle.Fixed3D;
            dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.Location = new Point(-1, 387);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvItems.RowTemplate.Height = 35;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(775, 306);
            dgvItems.TabIndex = 13;
            dgvItems.SelectionChanged += dgvItems_SelectionChanged_1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Kingdom";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Type";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(143, 244);
            cbType.Margin = new Padding(4);
            cbType.Name = "cbType";
            cbType.Size = new Size(205, 37);
            cbType.TabIndex = 8;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // cbKingdom
            // 
            cbKingdom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKingdom.FormattingEnabled = true;
            cbKingdom.Location = new Point(143, 209);
            cbKingdom.Margin = new Padding(4);
            cbKingdom.Name = "cbKingdom";
            cbKingdom.Size = new Size(205, 37);
            cbKingdom.TabIndex = 32;
            // 
            // picItem
            // 
            picItem.Location = new Point(473, 74);
            picItem.Margin = new Padding(4);
            picItem.Name = "picItem";
            picItem.Size = new Size(330, 305);
            picItem.SizeMode = PictureBoxSizeMode.StretchImage;
            picItem.TabIndex = 33;
            picItem.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(105, 132);
            materialLabel1.Margin = new Padding(4, 0, 4, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(35, 27);
            materialLabel1.TabIndex = 34;
            materialLabel1.Text = "Id:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(66, 169);
            materialLabel2.Margin = new Padding(4, 0, 4, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(76, 27);
            materialLabel2.TabIndex = 35;
            materialLabel2.Text = "Name:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(42, 209);
            materialLabel3.Margin = new Padding(4, 0, 4, 0);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(104, 27);
            materialLabel3.TabIndex = 36;
            materialLabel3.Text = "Kingdom:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel4.Location = new Point(76, 244);
            materialLabel4.Margin = new Padding(4, 0, 4, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(64, 27);
            materialLabel4.TabIndex = 37;
            materialLabel4.Text = "Type:";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(774, 387);
            materialDivider1.Margin = new Padding(4);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(87, 119);
            materialDivider1.TabIndex = 38;
            materialDivider1.Text = "materialDivider1";
            // 
            // btnCreatee
            // 
            btnCreatee.AutoSize = true;
            btnCreatee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreatee.Depth = 0;
            btnCreatee.Icon = null;
            btnCreatee.Location = new Point(176, 286);
            btnCreatee.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreatee.Name = "btnCreatee";
            btnCreatee.Primary = true;
            btnCreatee.Size = new Size(99, 36);
            btnCreatee.TabIndex = 39;
            btnCreatee.Text = "CREATE";
            btnCreatee.UseVisualStyleBackColor = true;
            btnCreatee.Click += btnCreatee_Click;
            // 
            // btnUpdatee
            // 
            btnUpdatee.AutoSize = true;
            btnUpdatee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdatee.Depth = 0;
            btnUpdatee.Icon = null;
            btnUpdatee.Location = new Point(780, 403);
            btnUpdatee.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdatee.Name = "btnUpdatee";
            btnUpdatee.Primary = true;
            btnUpdatee.Size = new Size(101, 36);
            btnUpdatee.TabIndex = 40;
            btnUpdatee.Text = "UPDATE";
            btnUpdatee.UseVisualStyleBackColor = true;
            btnUpdatee.Click += btnUpdatee_Click;
            // 
            // btnDeletee
            // 
            btnDeletee.AutoSize = true;
            btnDeletee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeletee.Depth = 0;
            btnDeletee.Icon = null;
            btnDeletee.Location = new Point(782, 452);
            btnDeletee.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeletee.Name = "btnDeletee";
            btnDeletee.Primary = true;
            btnDeletee.Size = new Size(95, 36);
            btnDeletee.TabIndex = 41;
            btnDeletee.Text = "DELETE";
            btnDeletee.UseVisualStyleBackColor = true;
            btnDeletee.Click += btnDeletee_Click;
            // 
            // txtId
            // 
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Hint = "";
            txtId.Location = new Point(143, 132);
            txtId.MaxLength = 32767;
            txtId.MouseState = MaterialSkin.MouseState.HOVER;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(205, 32);
            txtId.TabIndex = 42;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            txtName.Depth = 0;
            txtName.Hint = "";
            txtName.Location = new Point(142, 169);
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.HOVER;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(206, 32);
            txtName.TabIndex = 43;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // CRUDitem
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(862, 702);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(picItem);
            Controls.Add(btnDeletee);
            Controls.Add(dgvItems);
            Controls.Add(btnUpdatee);
            Controls.Add(btnCreatee);
            Controls.Add(materialDivider1);
            Controls.Add(cbType);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(cbKingdom);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "CRUDitem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDitem";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)picItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private ComboBox cbType;
        private ComboBox cbKingdom;
        private PictureBox picItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreatee;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdatee;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeletee;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
    }
}