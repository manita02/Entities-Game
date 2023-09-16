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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvItems = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            posOrNeg = new DataGridViewCheckBoxColumn();
            type = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            txtValue = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            cbType = new ComboBox();
            label3 = new Label();
            rdbNegative = new RadioButton();
            rdbPositive = new RadioButton();
            label5 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(dgvItems);
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(cbType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rdbNegative);
            groupBox1.Controls.Add(rdbPositive);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 387);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Item";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(453, 89);
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
            btnCreate.Location = new Point(209, 166);
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
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { id, name, posOrNeg, type, value });
            dgvItems.Location = new Point(20, 208);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowTemplate.Height = 25;
            dgvItems.Size = new Size(666, 163);
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
            // posOrNeg
            // 
            posOrNeg.HeaderText = "Its Positive?";
            posOrNeg.Name = "posOrNeg";
            posOrNeg.ReadOnly = true;
            posOrNeg.Resizable = DataGridViewTriState.True;
            posOrNeg.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // type
            // 
            type.HeaderText = "Type";
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // value
            // 
            value.HeaderText = "Value";
            value.Name = "value";
            value.ReadOnly = true;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(84, 163);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(100, 23);
            txtValue.TabIndex = 11;
            txtValue.KeyPress += txtValue_KeyPress;
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
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(63, 134);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 23);
            cbType.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 137);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Type:";
            // 
            // rdbNegative
            // 
            rdbNegative.AutoSize = true;
            rdbNegative.Location = new Point(20, 109);
            rdbNegative.Name = "rdbNegative";
            rdbNegative.Size = new Size(72, 19);
            rdbNegative.TabIndex = 6;
            rdbNegative.TabStop = true;
            rdbNegative.Text = "Negative";
            rdbNegative.UseVisualStyleBackColor = true;
            // 
            // rdbPositive
            // 
            rdbPositive.AutoSize = true;
            rdbPositive.Location = new Point(20, 88);
            rdbPositive.Name = "rdbPositive";
            rdbPositive.Size = new Size(66, 19);
            rdbPositive.TabIndex = 5;
            rdbPositive.TabStop = true;
            rdbPositive.Text = "Positive";
            rdbPositive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 171);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 66);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // CRUDitem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "CRUDitem";
            Text = "CRUDitem";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbType;
        private Label label3;
        private RadioButton rdbNegative;
        private RadioButton rdbPositive;
        private Label label5;
        private Label label2;
        private TextBox txtValue;
        private TextBox txtName;
        private TextBox txtId;
        private DataGridView dgvItems;
        private Button btnCreate;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewCheckBoxColumn posOrNeg;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn value;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnDelete;
    }
}