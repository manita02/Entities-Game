namespace crudsGame.src.views
{
    partial class CRUDfood
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
            cbDiet = new ComboBox();
            label4 = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCalories = new TextBox();
            label3 = new Label();
            dgvFoods = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            diet = new DataGridViewTextBoxColumn();
            calories = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbDiet
            // 
            cbDiet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDiet.FormattingEnabled = true;
            cbDiet.Location = new Point(99, 99);
            cbDiet.Name = "cbDiet";
            cbDiet.Size = new Size(160, 23);
            cbDiet.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 102);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 37;
            label4.Text = "Diet:";
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 36;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(98, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 71);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 34;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 33;
            label1.Text = "Id:";
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(99, 128);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(100, 23);
            txtCalories.TabIndex = 40;
            txtCalories.KeyPress += txtCalories_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 133);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 39;
            label3.Text = "Calories:";
            // 
            // dgvFoods
            // 
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Columns.AddRange(new DataGridViewColumn[] { id, name, diet, calories });
            dgvFoods.Location = new Point(12, 215);
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowTemplate.Height = 25;
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.Size = new Size(752, 212);
            dgvFoods.TabIndex = 41;
            dgvFoods.SelectionChanged += dgvFoods_SelectionChanged;
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
            // diet
            // 
            diet.HeaderText = "Diet";
            diet.Name = "diet";
            diet.ReadOnly = true;
            // 
            // calories
            // 
            calories.HeaderText = "Calories";
            calories.Name = "calories";
            calories.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(518, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 100);
            groupBox2.TabIndex = 42;
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
            btnCreate.Location = new Point(147, 167);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 43;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // CRUDfood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(groupBox2);
            Controls.Add(dgvFoods);
            Controls.Add(txtCalories);
            Controls.Add(label3);
            Controls.Add(cbDiet);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CRUDfood";
            Text = "CRUDfood";
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDiet;
        private Label label4;
        private TextBox txtName;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private TextBox txtCalories;
        private Label label3;
        private DataGridView dgvFoods;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn diet;
        private DataGridViewTextBoxColumn calories;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
    }
}