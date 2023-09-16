namespace crudsGame.src.views
{
    partial class pruebas
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
            label2 = new Label();
            label3 = new Label();
            rdbPositive = new RadioButton();
            rdbNegative = new RadioButton();
            txtId = new TextBox();
            txtName = new TextBox();
            txtValue = new TextBox();
            btnCreateItem = new Button();
            dgvItems = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 66);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 149);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Value:";
            // 
            // rdbPositive
            // 
            rdbPositive.AutoSize = true;
            rdbPositive.Location = new Point(20, 93);
            rdbPositive.Name = "rdbPositive";
            rdbPositive.Size = new Size(112, 19);
            rdbPositive.TabIndex = 3;
            rdbPositive.TabStop = true;
            rdbPositive.Text = "Increases energy";
            rdbPositive.UseVisualStyleBackColor = true;
            // 
            // rdbNegative
            // 
            rdbNegative.AutoSize = true;
            rdbNegative.Location = new Point(20, 118);
            rdbNegative.Name = "rdbNegative";
            rdbNegative.Size = new Size(88, 19);
            rdbNegative.TabIndex = 4;
            rdbNegative.TabStop = true;
            rdbNegative.Text = "Lose energy";
            rdbNegative.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(44, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            txtId.Text = "0";
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(64, 146);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(100, 23);
            txtValue.TabIndex = 7;
            //txtValue.KeyPress += txtValue_KeyPress;
            // 
            // btnCreateItem
            // 
            btnCreateItem.Location = new Point(44, 187);
            btnCreateItem.Name = "btnCreateItem";
            btnCreateItem.Size = new Size(75, 23);
            btnCreateItem.TabIndex = 8;
            btnCreateItem.Text = "CREATE";
            btnCreateItem.UseVisualStyleBackColor = true;
            //btnCreateItem.Click += btnCreateItem_Click;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { Id, Name, value, Type });
            dgvItems.Location = new Point(234, 12);
            dgvItems.Name = "dgvItems";
            dgvItems.RowTemplate.Height = 25;
            dgvItems.Size = new Size(591, 320);
            dgvItems.TabIndex = 9;
            //dgvItems.SelectionChanged += dgvItems_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            // 
            // Name
            // 
            Name.HeaderText = "name";
            Name.Name = "Name";
            // 
            // value
            // 
            value.HeaderText = "value";
            value.Name = "value";
            // 
            // Type
            // 
            Type.HeaderText = "type";
            Type.Name = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 291);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(27, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            //btnUpdate.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(27, 55);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            //btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rdbPositive);
            groupBox1.Controls.Add(btnCreateItem);
            groupBox1.Controls.Add(rdbNegative);
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 226);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Item";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(468, 338);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(130, 84);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "> Select a row for...";
            // 
            // pruebas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 435);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(dgvItems);
            //Name = "pruebas";
            Text = "pruebas";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rdbPositive;
        private RadioButton rdbNegative;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtValue;
        private Button btnCreateItem;
        private DataGridView dgvItems;
        private Label label4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn value;
        private DataGridViewTextBoxColumn Type;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}