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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDitem));
            label1 = new Label();
            groupBox1 = new GroupBox();
            picItem = new PictureBox();
            cbKingdom = new ComboBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvItems = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            kingdom = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            txtName = new TextBox();
            txtId = new TextBox();
            cbType = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItem).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(picItem);
            groupBox1.Controls.Add(cbKingdom);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(cbType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 324);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Item";
            // 
            // picItem
            // 
            picItem.Location = new Point(344, 22);
            picItem.Name = "picItem";
            picItem.Size = new Size(316, 290);
            picItem.SizeMode = PictureBoxSizeMode.StretchImage;
            picItem.TabIndex = 33;
            picItem.TabStop = false;
            // 
            // cbKingdom
            // 
            cbKingdom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKingdom.FormattingEnabled = true;
            cbKingdom.Location = new Point(85, 94);
            cbKingdom.Name = "cbKingdom";
            cbKingdom.Size = new Size(160, 23);
            cbKingdom.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 97);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 31;
            label4.Text = "Kingdom:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(41, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 100);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "> Select a row to...";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(25, 50);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(117, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(118, 166);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { id, name, kingdom, type });
            dgvItems.Location = new Point(12, 339);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowTemplate.Height = 25;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(688, 279);
            dgvItems.TabIndex = 12;
            dgvItems.SelectionChanged += dgvItems_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // kingdom
            // 
            kingdom.HeaderText = "Kingdom";
            kingdom.Name = "kingdom";
            kingdom.ReadOnly = true;
            // 
            // type
            // 
            type.HeaderText = "Type";
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(84, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(84, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 9;
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(85, 123);
            cbType.Name = "cbType";
            cbType.Size = new Size(160, 23);
            cbType.TabIndex = 8;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 126);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 66);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // CRUDitem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 630);
            Controls.Add(groupBox1);
            Controls.Add(dgvItems);
            Name = "CRUDitem";
            Text = "CRUDitem";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItem).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbType;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private TextBox txtId;
        private DataGridView dgvItems;
        private Button btnCreate;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cbKingdom;
        private Label label4;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn kingdom;
        private DataGridViewTextBoxColumn type;
        private PictureBox picItem;
    }
}