namespace crudsGame.src.views
{
    partial class CRUDentity
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            cbKingdom = new ComboBox();
            txtName = new TextBox();
            cbDiet = new ComboBox();
            cbEnvironment = new ComboBox();
            txtAttack = new TextBox();
            txtDefense = new TextBox();
            txtRange = new TextBox();
            dgvEntities = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            kingdom = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            diet = new DataGridViewTextBoxColumn();
            environment = new DataGridViewTextBoxColumn();
            attackPoints = new DataGridViewTextBoxColumn();
            defensePoints = new DataGridViewTextBoxColumn();
            attackRange = new DataGridViewTextBoxColumn();
            maxEnergy = new DataGridViewTextBoxColumn();
            currentEnergy = new DataGridViewTextBoxColumn();
            maxLife = new DataGridViewTextBoxColumn();
            currentLife = new DataGridViewTextBoxColumn();
            btnCreate = new Button();
            txtMaxEnergy = new TextBox();
            label9 = new Label();
            label11 = new Label();
            txtMaxLife = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            picCreature = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCreature).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 19);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 61);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Kingdom: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 101);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 136);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Diet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 176);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Environment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 219);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 5;
            label6.Text = "Attack Points:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 260);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 6;
            label7.Text = "Defense Points:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 300);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 7;
            label8.Text = "Attack Range: ";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(107, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // cbKingdom
            // 
            cbKingdom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKingdom.FormattingEnabled = true;
            cbKingdom.Location = new Point(107, 58);
            cbKingdom.Name = "cbKingdom";
            cbKingdom.Size = new Size(121, 23);
            cbKingdom.TabIndex = 9;
            cbKingdom.SelectedIndexChanged += cbKingdom_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 98);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "type a name...";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 10;
            // 
            // cbDiet
            // 
            cbDiet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDiet.FormattingEnabled = true;
            cbDiet.Location = new Point(107, 136);
            cbDiet.Name = "cbDiet";
            cbDiet.Size = new Size(121, 23);
            cbDiet.TabIndex = 11;
            // 
            // cbEnvironment
            // 
            cbEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEnvironment.FormattingEnabled = true;
            cbEnvironment.Location = new Point(107, 176);
            cbEnvironment.Name = "cbEnvironment";
            cbEnvironment.Size = new Size(121, 23);
            cbEnvironment.TabIndex = 12;
            // 
            // txtAttack
            // 
            txtAttack.Location = new Point(107, 216);
            txtAttack.Name = "txtAttack";
            txtAttack.PlaceholderText = "type a number...";
            txtAttack.Size = new Size(100, 23);
            txtAttack.TabIndex = 13;
            txtAttack.KeyPress += txtAttack_KeyPress;
            // 
            // txtDefense
            // 
            txtDefense.Location = new Point(107, 257);
            txtDefense.Name = "txtDefense";
            txtDefense.PlaceholderText = "type a number...";
            txtDefense.Size = new Size(100, 23);
            txtDefense.TabIndex = 14;
            txtDefense.KeyPress += txtDefense_KeyPress;
            // 
            // txtRange
            // 
            txtRange.Location = new Point(107, 297);
            txtRange.Name = "txtRange";
            txtRange.PlaceholderText = "type a number...";
            txtRange.Size = new Size(100, 23);
            txtRange.TabIndex = 15;
            txtRange.KeyPress += txtRange_KeyPress;
            // 
            // dgvEntities
            // 
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Columns.AddRange(new DataGridViewColumn[] { id, kingdom, name, diet, environment, attackPoints, defensePoints, attackRange, maxEnergy, currentEnergy, maxLife, currentLife });
            dgvEntities.Location = new Point(12, 347);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.ReadOnly = true;
            dgvEntities.RowTemplate.Height = 25;
            dgvEntities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntities.Size = new Size(1294, 281);
            dgvEntities.TabIndex = 16;
            dgvEntities.SelectionChanged += dgvEntities_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // kingdom
            // 
            kingdom.HeaderText = "Kingdom";
            kingdom.Name = "kingdom";
            kingdom.ReadOnly = true;
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
            // environment
            // 
            environment.HeaderText = "Environment";
            environment.Name = "environment";
            environment.ReadOnly = true;
            // 
            // attackPoints
            // 
            attackPoints.HeaderText = "Attack Points";
            attackPoints.Name = "attackPoints";
            attackPoints.ReadOnly = true;
            // 
            // defensePoints
            // 
            defensePoints.HeaderText = "Defense Points";
            defensePoints.Name = "defensePoints";
            defensePoints.ReadOnly = true;
            // 
            // attackRange
            // 
            attackRange.HeaderText = "Attack Range";
            attackRange.Name = "attackRange";
            attackRange.ReadOnly = true;
            // 
            // maxEnergy
            // 
            maxEnergy.HeaderText = "Max Energy";
            maxEnergy.Name = "maxEnergy";
            maxEnergy.ReadOnly = true;
            // 
            // currentEnergy
            // 
            currentEnergy.HeaderText = "Current Energy";
            currentEnergy.Name = "currentEnergy";
            currentEnergy.ReadOnly = true;
            // 
            // maxLife
            // 
            maxLife.HeaderText = "Max Life";
            maxLife.Name = "maxLife";
            maxLife.ReadOnly = true;
            // 
            // currentLife
            // 
            currentLife.HeaderText = "Current Life";
            currentLife.Name = "currentLife";
            currentLife.ReadOnly = true;
            // 
            // btnCreate
            // 
            btnCreate.ForeColor = SystemColors.ActiveCaptionText;
            btnCreate.Location = new Point(310, 219);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtMaxEnergy
            // 
            txtMaxEnergy.Location = new Point(346, 16);
            txtMaxEnergy.Name = "txtMaxEnergy";
            txtMaxEnergy.PlaceholderText = "type a number...";
            txtMaxEnergy.Size = new Size(100, 23);
            txtMaxEnergy.TabIndex = 18;
            txtMaxEnergy.Text = "100";
            txtMaxEnergy.KeyPress += txtMaxEnergy_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(268, 19);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 19;
            label9.Text = "Max Energy:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(285, 61);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 21;
            label11.Text = "Max Life:";
            // 
            // txtMaxLife
            // 
            txtMaxLife.Location = new Point(346, 58);
            txtMaxLife.Name = "txtMaxLife";
            txtMaxLife.PlaceholderText = "type a number...";
            txtMaxLife.Size = new Size(100, 23);
            txtMaxLife.TabIndex = 24;
            txtMaxLife.Text = "100";
            txtMaxLife.KeyPress += txtMaxLife_KeyPress;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(picCreature);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaxLife);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtMaxEnergy);
            groupBox1.Controls.Add(cbKingdom);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(cbDiet);
            groupBox1.Controls.Add(cbEnvironment);
            groupBox1.Controls.Add(txtRange);
            groupBox1.Controls.Add(txtAttack);
            groupBox1.Controls.Add(txtDefense);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(52, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1193, 326);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "> Create a creature";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(959, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 100);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "> Select a row to...";
            // 
            // picCreature
            // 
            picCreature.Location = new Point(466, 22);
            picCreature.Name = "picCreature";
            picCreature.Size = new Size(463, 288);
            picCreature.SizeMode = PictureBoxSizeMode.StretchImage;
            picCreature.TabIndex = 26;
            picCreature.TabStop = false;
            // 
            // CRUDentity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backMain;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1333, 630);
            Controls.Add(groupBox1);
            Controls.Add(dgvEntities);
            Name = "CRUDentity";
            Text = "CRUDentity";
            ((System.ComponentModel.ISupportInitialize)dgvEntities).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCreature).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtId;
        private ComboBox cbKingdom;
        private TextBox txtName;
        private ComboBox cbDiet;
        private ComboBox cbEnvironment;
        private TextBox txtAttack;
        private TextBox txtDefense;
        private TextBox txtRange;
        private DataGridView dgvEntities;
        private Button btnCreate;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn kingdom;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn diet;
        private DataGridViewTextBoxColumn environment;
        private DataGridViewTextBoxColumn attackPoints;
        private DataGridViewTextBoxColumn defensePoints;
        private DataGridViewTextBoxColumn attackRange;
        private DataGridViewTextBoxColumn maxEnergy;
        private DataGridViewTextBoxColumn currentEnergy;
        private DataGridViewTextBoxColumn maxLife;
        private DataGridViewTextBoxColumn currentLife;
        private TextBox txtMaxEnergy;
        private Label label9;
        private Label label11;
        private TextBox txtMaxLife;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox picCreature;
    }
}