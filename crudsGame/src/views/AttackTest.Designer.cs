namespace crudsGame.src.views
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttackTest));
            groupBox1 = new GroupBox();
            lbCurrentEnergyJ1 = new Label();
            btnSleep = new Button();
            lbLifeJ1 = new Label();
            btnInteract = new Button();
            label2 = new Label();
            txtDiet = new TextBox();
            label1 = new Label();
            btnComer = new Button();
            pbCurrentEnergy = new ProgressBar();
            pbCurrentLife = new ProgressBar();
            label10 = new Label();
            cbFoods = new ComboBox();
            txtId = new TextBox();
            cbItems = new ComboBox();
            label9 = new Label();
            txtKingdom = new TextBox();
            txtEnvironment = new TextBox();
            txtMaxEnergy = new TextBox();
            txtMaxLife = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDefense = new TextBox();
            txtAttack = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnImportant = new Button();
            cbCreaturesPlayerOne = new ComboBox();
            groupBox2 = new GroupBox();
            lbCurrentLifeJ2 = new Label();
            btnAttack = new Button();
            cbCreaturesPlayerTwo = new ComboBox();
            lbCurrentEnergyJ2 = new Label();
            groupBox3 = new GroupBox();
            btnMap = new Button();
            cbBorderingTerrainsOfCurrentTerrain = new ComboBox();
            cbCurrentTerrain = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            bindingTerrains = new BindingSource(components);
            bindingBonderingTerrains = new BindingSource(components);
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingTerrains).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingBonderingTerrains).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbCurrentEnergyJ1);
            groupBox1.Controls.Add(btnSleep);
            groupBox1.Controls.Add(lbLifeJ1);
            groupBox1.Controls.Add(btnInteract);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDiet);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnComer);
            groupBox1.Controls.Add(pbCurrentEnergy);
            groupBox1.Controls.Add(pbCurrentLife);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbFoods);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(cbItems);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtKingdom);
            groupBox1.Controls.Add(txtEnvironment);
            groupBox1.Controls.Add(txtMaxEnergy);
            groupBox1.Controls.Add(txtMaxLife);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDefense);
            groupBox1.Controls.Add(txtAttack);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnImportant);
            groupBox1.Controls.Add(cbCreaturesPlayerOne);
            groupBox1.Location = new Point(24, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1135, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose a CRIATURE (Player One)";
            // 
            // lbCurrentEnergyJ1
            // 
            lbCurrentEnergyJ1.AutoSize = true;
            lbCurrentEnergyJ1.Location = new Point(641, 66);
            lbCurrentEnergyJ1.Name = "lbCurrentEnergyJ1";
            lbCurrentEnergyJ1.Size = new Size(22, 15);
            lbCurrentEnergyJ1.TabIndex = 7;
            lbCurrentEnergyJ1.Text = "***";
            // 
            // btnSleep
            // 
            btnSleep.Location = new Point(910, 190);
            btnSleep.Name = "btnSleep";
            btnSleep.Size = new Size(75, 23);
            btnSleep.TabIndex = 13;
            btnSleep.Text = "SLEEP";
            btnSleep.UseVisualStyleBackColor = true;
            btnSleep.Click += btnSleep_Click;
            // 
            // lbLifeJ1
            // 
            lbLifeJ1.AutoSize = true;
            lbLifeJ1.Location = new Point(641, 16);
            lbLifeJ1.Name = "lbLifeJ1";
            lbLifeJ1.Size = new Size(22, 15);
            lbLifeJ1.TabIndex = 6;
            lbLifeJ1.Text = "***";
            // 
            // btnInteract
            // 
            btnInteract.Location = new Point(1006, 58);
            btnInteract.Name = "btnInteract";
            btnInteract.Size = new Size(75, 23);
            btnInteract.TabIndex = 12;
            btnInteract.Text = "interact";
            btnInteract.UseVisualStyleBackColor = true;
            btnInteract.Click += btnInteract_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 66);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Energy";
            // 
            // txtDiet
            // 
            txtDiet.Location = new Point(586, 123);
            txtDiet.Name = "txtDiet";
            txtDiet.Size = new Size(100, 23);
            txtDiet.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 16);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 4;
            label1.Text = "Life";
            // 
            // btnComer
            // 
            btnComer.Location = new Point(1024, 122);
            btnComer.Name = "btnComer";
            btnComer.Size = new Size(75, 23);
            btnComer.TabIndex = 11;
            btnComer.Text = "comer";
            btnComer.UseVisualStyleBackColor = true;
            btnComer.Click += btnComer_Click;
            // 
            // pbCurrentEnergy
            // 
            pbCurrentEnergy.BackColor = Color.Yellow;
            pbCurrentEnergy.ForeColor = Color.Gold;
            pbCurrentEnergy.Location = new Point(406, 63);
            pbCurrentEnergy.Name = "pbCurrentEnergy";
            pbCurrentEnergy.Size = new Size(229, 23);
            pbCurrentEnergy.TabIndex = 3;
            // 
            // pbCurrentLife
            // 
            pbCurrentLife.BackColor = Color.Lime;
            pbCurrentLife.ForeColor = Color.DarkSeaGreen;
            pbCurrentLife.Location = new Point(406, 15);
            pbCurrentLife.Name = "pbCurrentLife";
            pbCurrentLife.Size = new Size(229, 23);
            pbCurrentLife.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(552, 126);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 17;
            label10.Text = "Diet";
            // 
            // cbFoods
            // 
            cbFoods.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoods.FormattingEnabled = true;
            cbFoods.Location = new Point(741, 122);
            cbFoods.Name = "cbFoods";
            cbFoods.Size = new Size(277, 23);
            cbFoods.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(586, 93);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 16;
            // 
            // cbItems
            // 
            cbItems.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItems.FormattingEnabled = true;
            cbItems.Location = new Point(741, 59);
            cbItems.Name = "cbItems";
            cbItems.Size = new Size(244, 23);
            cbItems.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(560, 97);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 15;
            label9.Text = "id:";
            // 
            // txtKingdom
            // 
            txtKingdom.Location = new Point(402, 159);
            txtKingdom.Name = "txtKingdom";
            txtKingdom.Size = new Size(100, 23);
            txtKingdom.TabIndex = 14;
            // 
            // txtEnvironment
            // 
            txtEnvironment.Location = new Point(406, 188);
            txtEnvironment.Name = "txtEnvironment";
            txtEnvironment.Size = new Size(100, 23);
            txtEnvironment.TabIndex = 13;
            // 
            // txtMaxEnergy
            // 
            txtMaxEnergy.Location = new Point(406, 216);
            txtMaxEnergy.Name = "txtMaxEnergy";
            txtMaxEnergy.Size = new Size(100, 23);
            txtMaxEnergy.TabIndex = 12;
            // 
            // txtMaxLife
            // 
            txtMaxLife.Location = new Point(406, 247);
            txtMaxLife.Name = "txtMaxLife";
            txtMaxLife.Size = new Size(100, 23);
            txtMaxLife.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 247);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 10;
            label8.Text = "max life";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(325, 219);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 9;
            label7.Text = "max energy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 194);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 8;
            label6.Text = "environment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 167);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 7;
            label5.Text = "kingdom";
            // 
            // txtDefense
            // 
            txtDefense.Location = new Point(423, 123);
            txtDefense.Name = "txtDefense";
            txtDefense.Size = new Size(100, 23);
            txtDefense.TabIndex = 6;
            // 
            // txtAttack
            // 
            txtAttack.Location = new Point(426, 92);
            txtAttack.Name = "txtAttack";
            txtAttack.Size = new Size(100, 23);
            txtAttack.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 123);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Defense Points";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 93);
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
            // cbCreaturesPlayerOne
            // 
            cbCreaturesPlayerOne.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCreaturesPlayerOne.FormattingEnabled = true;
            cbCreaturesPlayerOne.Location = new Point(6, 31);
            cbCreaturesPlayerOne.Name = "cbCreaturesPlayerOne";
            cbCreaturesPlayerOne.Size = new Size(309, 23);
            cbCreaturesPlayerOne.TabIndex = 0;
            cbCreaturesPlayerOne.SelectedIndexChanged += cbMainCreature_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbCurrentLifeJ2);
            groupBox2.Controls.Add(btnAttack);
            groupBox2.Controls.Add(cbCreaturesPlayerTwo);
            groupBox2.Controls.Add(lbCurrentEnergyJ2);
            groupBox2.Location = new Point(24, 333);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(596, 173);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select a creature to ATTACK (Player Two)";
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
            // cbCreaturesPlayerTwo
            // 
            cbCreaturesPlayerTwo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCreaturesPlayerTwo.FormattingEnabled = true;
            cbCreaturesPlayerTwo.Location = new Point(8, 43);
            cbCreaturesPlayerTwo.Name = "cbCreaturesPlayerTwo";
            cbCreaturesPlayerTwo.Size = new Size(380, 23);
            cbCreaturesPlayerTwo.TabIndex = 0;
            cbCreaturesPlayerTwo.SelectedIndexChanged += cbCriatureToDefense_SelectedIndexChanged;
            // 
            // lbCurrentEnergyJ2
            // 
            lbCurrentEnergyJ2.AutoSize = true;
            lbCurrentEnergyJ2.Location = new Point(426, 32);
            lbCurrentEnergyJ2.Name = "lbCurrentEnergyJ2";
            lbCurrentEnergyJ2.Size = new Size(58, 15);
            lbCurrentEnergyJ2.TabIndex = 8;
            lbCurrentEnergyJ2.Text = "Energy_J2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnMap);
            groupBox3.Controls.Add(cbBorderingTerrainsOfCurrentTerrain);
            groupBox3.Controls.Add(cbCurrentTerrain);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(634, 333);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(525, 192);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "SELECT A TERRAIN";
            // 
            // btnMap
            // 
            btnMap.Location = new Point(386, 89);
            btnMap.Name = "btnMap";
            btnMap.Size = new Size(133, 23);
            btnMap.TabIndex = 4;
            btnMap.Text = "CREATE MAP";
            btnMap.UseVisualStyleBackColor = true;
            btnMap.Click += btnMap_Click;
            // 
            // cbBorderingTerrainsOfCurrentTerrain
            // 
            cbBorderingTerrainsOfCurrentTerrain.FormattingEnabled = true;
            cbBorderingTerrainsOfCurrentTerrain.Location = new Point(123, 144);
            cbBorderingTerrainsOfCurrentTerrain.Name = "cbBorderingTerrainsOfCurrentTerrain";
            cbBorderingTerrainsOfCurrentTerrain.Size = new Size(231, 23);
            cbBorderingTerrainsOfCurrentTerrain.TabIndex = 3;
            // 
            // cbCurrentTerrain
            // 
            cbCurrentTerrain.FormattingEnabled = true;
            cbCurrentTerrain.Location = new Point(108, 25);
            cbCurrentTerrain.Name = "cbCurrentTerrain";
            cbCurrentTerrain.Size = new Size(231, 23);
            cbCurrentTerrain.TabIndex = 2;
            cbCurrentTerrain.SelectedIndexChanged += cbCurrentTerrain_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 126);
            label12.Name = "label12";
            label12.Size = new Size(244, 15);
            label12.TabIndex = 1;
            label12.Text = "Terrenos Limitrofes del Terreno Seleccionado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 29);
            label11.Name = "label11";
            label11.Size = new Size(88, 15);
            label11.TabIndex = 0;
            label11.Text = "Select a Terrain:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(637, 535);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(457, 169);
            listBox1.TabIndex = 3;
            // 
            // AttackTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.interactions;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1206, 718);
            Controls.Add(listBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AttackTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttackTest";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingTerrains).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingBonderingTerrains).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbCreaturesPlayerOne;
        private Button btnImportant;
        private GroupBox groupBox2;
        private ComboBox cbCreaturesPlayerTwo;
        private Button btnAttack;
        private ProgressBar pbCurrentLife;
        private ProgressBar pbCurrentEnergy;
        private Label label1;
        private Label label2;
        private Label lbLifeJ1;
        private Label lbCurrentEnergyJ1;
        private Label lbCurrentEnergyJ2;
        private Label lbCurrentLifeJ2;
        private ComboBox cbItems;
        private ComboBox cbFoods;
        private Button btnComer;
        private Button btnInteract;
        private TextBox txtDefense;
        private TextBox txtAttack;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtKingdom;
        private TextBox txtEnvironment;
        private TextBox txtMaxEnergy;
        private TextBox txtMaxLife;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private TextBox txtId;
        private Button btnSleep;
        private TextBox txtDiet;
        private Label label10;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private ComboBox cbBorderingTerrainsOfCurrentTerrain;
        private ComboBox cbCurrentTerrain;
        private Button btnMap;
        private BindingSource bindingTerrains;
        private BindingSource bindingBonderingTerrains;
        private ListBox listBox1;
    }
}