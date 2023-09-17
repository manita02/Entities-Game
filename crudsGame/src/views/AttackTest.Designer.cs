﻿namespace crudsGame.src.views
{
    partial class AttackTest
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
            groupBox1 = new GroupBox();
            txtDefense = new TextBox();
            txtAttack = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnImportant = new Button();
            cbMainCreature = new ComboBox();
            groupBox2 = new GroupBox();
            lbCurrentLifeJ2 = new Label();
            btnAttack = new Button();
            cbCreaturesThatWillBeAttacked = new ComboBox();
            pbCurrentLife = new ProgressBar();
            pbCurrentEnergy = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            lbLifeJ1 = new Label();
            lbCurrentEnergyJ1 = new Label();
            lbCurrentEnergyJ2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnComer = new Button();
            btnInteract = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDefense);
            groupBox1.Controls.Add(txtAttack);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnImportant);
            groupBox1.Controls.Add(cbMainCreature);
            groupBox1.Location = new Point(24, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose a CRIATURE";
            // 
            // txtDefense
            // 
            txtDefense.Location = new Point(484, 123);
            txtDefense.Name = "txtDefense";
            txtDefense.Size = new Size(100, 23);
            txtDefense.TabIndex = 6;
            // 
            // txtAttack
            // 
            txtAttack.Location = new Point(487, 92);
            txtAttack.Name = "txtAttack";
            txtAttack.Size = new Size(100, 23);
            txtAttack.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 123);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Defense Points";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 93);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Attack Points";
            // 
            // btnImportant
            // 
            btnImportant.Location = new Point(92, 64);
            btnImportant.Name = "btnImportant";
            btnImportant.Size = new Size(129, 23);
            btnImportant.TabIndex = 1;
            btnImportant.Text = "INFO. IMPORTANTE!!!";
            btnImportant.UseVisualStyleBackColor = true;
            btnImportant.Visible = false;
            // 
            // cbMainCreature
            // 
            cbMainCreature.FormattingEnabled = true;
            cbMainCreature.Location = new Point(6, 31);
            cbMainCreature.Name = "cbMainCreature";
            cbMainCreature.Size = new Size(309, 23);
            cbMainCreature.TabIndex = 0;
            cbMainCreature.SelectedIndexChanged += cbMainCreature_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbCurrentLifeJ2);
            groupBox2.Controls.Add(btnAttack);
            groupBox2.Controls.Add(cbCreaturesThatWillBeAttacked);
            groupBox2.Location = new Point(24, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(596, 173);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select a creature to ATTACK";
            // 
            // lbCurrentLifeJ2
            // 
            lbCurrentLifeJ2.AutoSize = true;
            lbCurrentLifeJ2.Location = new Point(443, 63);
            lbCurrentLifeJ2.Name = "lbCurrentLifeJ2";
            lbCurrentLifeJ2.Size = new Size(41, 15);
            lbCurrentLifeJ2.TabIndex = 9;
            lbCurrentLifeJ2.Text = "Life_J2";
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(41, 113);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(143, 38);
            btnAttack.TabIndex = 1;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // cbCreaturesThatWillBeAttacked
            // 
            cbCreaturesThatWillBeAttacked.FormattingEnabled = true;
            cbCreaturesThatWillBeAttacked.Location = new Point(8, 43);
            cbCreaturesThatWillBeAttacked.Name = "cbCreaturesThatWillBeAttacked";
            cbCreaturesThatWillBeAttacked.Size = new Size(380, 23);
            cbCreaturesThatWillBeAttacked.TabIndex = 0;
            cbCreaturesThatWillBeAttacked.SelectedIndexChanged += cbCriatureToDefense_SelectedIndexChanged;
            // 
            // pbCurrentLife
            // 
            pbCurrentLife.BackColor = Color.Lime;
            pbCurrentLife.ForeColor = Color.DarkSeaGreen;
            pbCurrentLife.Location = new Point(467, 38);
            pbCurrentLife.Name = "pbCurrentLife";
            pbCurrentLife.Size = new Size(229, 23);
            pbCurrentLife.TabIndex = 2;
            // 
            // pbCurrentEnergy
            // 
            pbCurrentEnergy.BackColor = Color.Yellow;
            pbCurrentEnergy.ForeColor = Color.Gold;
            pbCurrentEnergy.Location = new Point(467, 86);
            pbCurrentEnergy.Name = "pbCurrentEnergy";
            pbCurrentEnergy.Size = new Size(229, 23);
            pbCurrentEnergy.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 39);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 4;
            label1.Text = "Life";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 89);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Energy";
            // 
            // lbLifeJ1
            // 
            lbLifeJ1.AutoSize = true;
            lbLifeJ1.Location = new Point(702, 39);
            lbLifeJ1.Name = "lbLifeJ1";
            lbLifeJ1.Size = new Size(22, 15);
            lbLifeJ1.TabIndex = 6;
            lbLifeJ1.Text = "***";
            // 
            // lbCurrentEnergyJ1
            // 
            lbCurrentEnergyJ1.AutoSize = true;
            lbCurrentEnergyJ1.Location = new Point(702, 89);
            lbCurrentEnergyJ1.Name = "lbCurrentEnergyJ1";
            lbCurrentEnergyJ1.Size = new Size(22, 15);
            lbCurrentEnergyJ1.TabIndex = 7;
            lbCurrentEnergyJ1.Text = "***";
            // 
            // lbCurrentEnergyJ2
            // 
            lbCurrentEnergyJ2.AutoSize = true;
            lbCurrentEnergyJ2.Location = new Point(467, 190);
            lbCurrentEnergyJ2.Name = "lbCurrentEnergyJ2";
            lbCurrentEnergyJ2.Size = new Size(58, 15);
            lbCurrentEnergyJ2.TabIndex = 8;
            lbCurrentEnergyJ2.Text = "Energy_J2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(65, 363);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 23);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(383, 363);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(277, 23);
            comboBox2.TabIndex = 10;
            // 
            // btnComer
            // 
            btnComer.Location = new Point(407, 409);
            btnComer.Name = "btnComer";
            btnComer.Size = new Size(75, 23);
            btnComer.TabIndex = 11;
            btnComer.Text = "comer";
            btnComer.UseVisualStyleBackColor = true;
            btnComer.Click += btnComer_Click;
            // 
            // btnInteract
            // 
            btnInteract.Location = new Point(146, 401);
            btnInteract.Name = "btnInteract";
            btnInteract.Size = new Size(75, 23);
            btnInteract.TabIndex = 12;
            btnInteract.Text = "interact";
            btnInteract.UseVisualStyleBackColor = true;
            btnInteract.Click += btnInteract_Click;
            // 
            // AttackTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInteract);
            Controls.Add(btnComer);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lbCurrentEnergyJ2);
            Controls.Add(lbCurrentEnergyJ1);
            Controls.Add(lbLifeJ1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbCurrentEnergy);
            Controls.Add(pbCurrentLife);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AttackTest";
            Text = "AttackTest";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbMainCreature;
        private Button btnImportant;
        private GroupBox groupBox2;
        private ComboBox cbCreaturesThatWillBeAttacked;
        private Button btnAttack;
        private ProgressBar pbCurrentLife;
        private ProgressBar pbCurrentEnergy;
        private Label label1;
        private Label label2;
        private Label lbLifeJ1;
        private Label lbCurrentEnergyJ1;
        private Label lbCurrentEnergyJ2;
        private Label lbCurrentLifeJ2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnComer;
        private Button btnInteract;
        private TextBox txtDefense;
        private TextBox txtAttack;
        private Label label4;
        private Label label3;
    }
}