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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDentity));
            cbKingdom = new ComboBox();
            cbDiet = new ComboBox();
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
            clbEnvironments = new CheckedListBox();
            picCreature = new PictureBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            txtAttack = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtDefense = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtRange = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtMaxEnergy = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtMaxLife = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnDeletee = new MaterialSkin.Controls.MaterialRaisedButton();
            btnUpdatee = new MaterialSkin.Controls.MaterialRaisedButton();
            btnCreatee = new MaterialSkin.Controls.MaterialRaisedButton();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCreature).BeginInit();
            SuspendLayout();
            // 
            // cbKingdom
            // 
            cbKingdom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKingdom.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbKingdom.FormattingEnabled = true;
            cbKingdom.Location = new Point(197, 223);
            cbKingdom.Margin = new Padding(4, 5, 4, 5);
            cbKingdom.Name = "cbKingdom";
            cbKingdom.Size = new Size(291, 37);
            cbKingdom.TabIndex = 9;
            cbKingdom.SelectedIndexChanged += cbKingdom_SelectedIndexChanged;
            // 
            // cbDiet
            // 
            cbDiet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDiet.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbDiet.FormattingEnabled = true;
            cbDiet.Location = new Point(197, 350);
            cbDiet.Margin = new Padding(4, 5, 4, 5);
            cbDiet.Name = "cbDiet";
            cbDiet.Size = new Size(290, 37);
            cbDiet.TabIndex = 11;
            // 
            // dgvEntities
            // 
            dgvEntities.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvEntities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEntities.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEntities.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEntities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Columns.AddRange(new DataGridViewColumn[] { id, kingdom, name, diet, environment, attackPoints, defensePoints, attackRange, maxEnergy, currentEnergy, maxLife, currentLife });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEntities.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEntities.Location = new Point(4, 656);
            dgvEntities.Margin = new Padding(4, 5, 4, 5);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.ReadOnly = true;
            dgvEntities.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEntities.RowHeadersVisible = false;
            dgvEntities.RowHeadersWidth = 62;
            dgvEntities.RowTemplate.Height = 25;
            dgvEntities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntities.Size = new Size(1717, 325);
            dgvEntities.TabIndex = 16;
            dgvEntities.SelectionChanged += dgvEntities_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 150;
            // 
            // kingdom
            // 
            kingdom.HeaderText = "Kingdom";
            kingdom.MinimumWidth = 8;
            kingdom.Name = "kingdom";
            kingdom.ReadOnly = true;
            kingdom.Width = 150;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 150;
            // 
            // diet
            // 
            diet.HeaderText = "Diet";
            diet.MinimumWidth = 8;
            diet.Name = "diet";
            diet.ReadOnly = true;
            diet.Width = 150;
            // 
            // environment
            // 
            environment.HeaderText = "Environment";
            environment.MinimumWidth = 8;
            environment.Name = "environment";
            environment.ReadOnly = true;
            environment.Width = 150;
            // 
            // attackPoints
            // 
            attackPoints.HeaderText = "Attack Points";
            attackPoints.MinimumWidth = 8;
            attackPoints.Name = "attackPoints";
            attackPoints.ReadOnly = true;
            attackPoints.Width = 150;
            // 
            // defensePoints
            // 
            defensePoints.HeaderText = "Defense Points";
            defensePoints.MinimumWidth = 8;
            defensePoints.Name = "defensePoints";
            defensePoints.ReadOnly = true;
            defensePoints.Width = 150;
            // 
            // attackRange
            // 
            attackRange.HeaderText = "Attack Range";
            attackRange.MinimumWidth = 8;
            attackRange.Name = "attackRange";
            attackRange.ReadOnly = true;
            attackRange.Width = 150;
            // 
            // maxEnergy
            // 
            maxEnergy.HeaderText = "Max Energy";
            maxEnergy.MinimumWidth = 8;
            maxEnergy.Name = "maxEnergy";
            maxEnergy.ReadOnly = true;
            maxEnergy.Width = 150;
            // 
            // currentEnergy
            // 
            currentEnergy.HeaderText = "Current Energy";
            currentEnergy.MinimumWidth = 8;
            currentEnergy.Name = "currentEnergy";
            currentEnergy.ReadOnly = true;
            currentEnergy.Width = 150;
            // 
            // maxLife
            // 
            maxLife.HeaderText = "Max Life";
            maxLife.MinimumWidth = 8;
            maxLife.Name = "maxLife";
            maxLife.ReadOnly = true;
            maxLife.Width = 150;
            // 
            // currentLife
            // 
            currentLife.HeaderText = "Current Life";
            currentLife.MinimumWidth = 8;
            currentLife.Name = "currentLife";
            currentLife.ReadOnly = true;
            currentLife.Width = 150;
            // 
            // clbEnvironments
            // 
            clbEnvironments.BackColor = SystemColors.ControlLight;
            clbEnvironments.BorderStyle = BorderStyle.None;
            clbEnvironments.CheckOnClick = true;
            clbEnvironments.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            clbEnvironments.FormattingEnabled = true;
            clbEnvironments.Location = new Point(670, 423);
            clbEnvironments.Margin = new Padding(4, 5, 4, 5);
            clbEnvironments.Name = "clbEnvironments";
            clbEnvironments.Size = new Size(233, 120);
            clbEnvironments.TabIndex = 30;
            // 
            // picCreature
            // 
            picCreature.Location = new Point(1083, 158);
            picCreature.Margin = new Padding(4, 5, 4, 5);
            picCreature.Name = "picCreature";
            picCreature.Size = new Size(661, 480);
            picCreature.SizeMode = PictureBoxSizeMode.StretchImage;
            picCreature.TabIndex = 26;
            picCreature.TabStop = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel4.Location = new Point(80, 230);
            materialLabel4.Margin = new Padding(7, 0, 7, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(104, 27);
            materialLabel4.TabIndex = 52;
            materialLabel4.Text = "Kingdom:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(126, 350);
            materialLabel3.Margin = new Padding(7, 0, 7, 0);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(55, 27);
            materialLabel3.TabIndex = 51;
            materialLabel3.Text = "Diet:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(107, 290);
            materialLabel2.Margin = new Padding(7, 0, 7, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(76, 27);
            materialLabel2.TabIndex = 50;
            materialLabel2.Text = "Name:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(147, 165);
            materialLabel1.Margin = new Padding(7, 0, 7, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(35, 27);
            materialLabel1.TabIndex = 49;
            materialLabel1.Text = "Id:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel5.Location = new Point(34, 423);
            materialLabel5.Margin = new Padding(7, 0, 7, 0);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(147, 27);
            materialLabel5.TabIndex = 53;
            materialLabel5.Text = "Attack Points:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel6.Location = new Point(520, 423);
            materialLabel6.Margin = new Padding(7, 0, 7, 0);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(140, 27);
            materialLabel6.TabIndex = 54;
            materialLabel6.Text = "Environment:";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel7.Location = new Point(19, 490);
            materialLabel7.Margin = new Padding(7, 0, 7, 0);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(165, 27);
            materialLabel7.TabIndex = 55;
            materialLabel7.Text = "Defense Points:";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel8.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel8.Location = new Point(524, 290);
            materialLabel8.Margin = new Padding(7, 0, 7, 0);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(136, 27);
            materialLabel8.TabIndex = 56;
            materialLabel8.Text = "Max. Energy:";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel9.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel9.Location = new Point(37, 558);
            materialLabel9.Margin = new Padding(7, 0, 7, 0);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(147, 27);
            materialLabel9.TabIndex = 57;
            materialLabel9.Text = "Attack Range:";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel10.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel10.Location = new Point(550, 353);
            materialLabel10.Margin = new Padding(7, 0, 7, 0);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(107, 27);
            materialLabel10.TabIndex = 58;
            materialLabel10.Text = "Max. Life:";
            // 
            // txtAttack
            // 
            txtAttack.Depth = 0;
            txtAttack.Hint = "";
            txtAttack.Location = new Point(194, 417);
            txtAttack.Margin = new Padding(4, 5, 4, 5);
            txtAttack.MaxLength = 32767;
            txtAttack.MouseState = MaterialSkin.MouseState.HOVER;
            txtAttack.Name = "txtAttack";
            txtAttack.PasswordChar = '\0';
            txtAttack.SelectedText = "";
            txtAttack.SelectionLength = 0;
            txtAttack.SelectionStart = 0;
            txtAttack.Size = new Size(294, 32);
            txtAttack.TabIndex = 61;
            txtAttack.TabStop = false;
            txtAttack.UseSystemPasswordChar = false;
            txtAttack.KeyPress += txtAttack_KeyPress_1;
            // 
            // txtName
            // 
            txtName.Depth = 0;
            txtName.Hint = "";
            txtName.Location = new Point(197, 283);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.HOVER;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(294, 32);
            txtName.TabIndex = 60;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Hint = "";
            txtId.Location = new Point(197, 158);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.MaxLength = 32767;
            txtId.MouseState = MaterialSkin.MouseState.HOVER;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(293, 32);
            txtId.TabIndex = 59;
            txtId.TabStop = false;
            txtId.Text = "0";
            txtId.UseSystemPasswordChar = false;
            // 
            // txtDefense
            // 
            txtDefense.Depth = 0;
            txtDefense.Hint = "";
            txtDefense.Location = new Point(194, 483);
            txtDefense.Margin = new Padding(4, 5, 4, 5);
            txtDefense.MaxLength = 32767;
            txtDefense.MouseState = MaterialSkin.MouseState.HOVER;
            txtDefense.Name = "txtDefense";
            txtDefense.PasswordChar = '\0';
            txtDefense.SelectedText = "";
            txtDefense.SelectionLength = 0;
            txtDefense.SelectionStart = 0;
            txtDefense.Size = new Size(294, 32);
            txtDefense.TabIndex = 62;
            txtDefense.TabStop = false;
            txtDefense.UseSystemPasswordChar = false;
            txtDefense.KeyPress += txtAttack_KeyPress_1;
            // 
            // txtRange
            // 
            txtRange.Depth = 0;
            txtRange.Hint = "";
            txtRange.Location = new Point(194, 552);
            txtRange.Margin = new Padding(4, 5, 4, 5);
            txtRange.MaxLength = 32767;
            txtRange.MouseState = MaterialSkin.MouseState.HOVER;
            txtRange.Name = "txtRange";
            txtRange.PasswordChar = '\0';
            txtRange.SelectedText = "";
            txtRange.SelectionLength = 0;
            txtRange.SelectionStart = 0;
            txtRange.Size = new Size(294, 32);
            txtRange.TabIndex = 63;
            txtRange.TabStop = false;
            txtRange.UseSystemPasswordChar = false;
            txtRange.KeyPress += txtAttack_KeyPress_1;
            // 
            // txtMaxEnergy
            // 
            txtMaxEnergy.Depth = 0;
            txtMaxEnergy.Hint = "";
            txtMaxEnergy.Location = new Point(670, 290);
            txtMaxEnergy.Margin = new Padding(4, 5, 4, 5);
            txtMaxEnergy.MaxLength = 32767;
            txtMaxEnergy.MouseState = MaterialSkin.MouseState.HOVER;
            txtMaxEnergy.Name = "txtMaxEnergy";
            txtMaxEnergy.PasswordChar = '\0';
            txtMaxEnergy.SelectedText = "";
            txtMaxEnergy.SelectionLength = 0;
            txtMaxEnergy.SelectionStart = 0;
            txtMaxEnergy.Size = new Size(294, 32);
            txtMaxEnergy.TabIndex = 64;
            txtMaxEnergy.TabStop = false;
            txtMaxEnergy.UseSystemPasswordChar = false;
            txtMaxEnergy.KeyPress += txtAttack_KeyPress_1;
            // 
            // txtMaxLife
            // 
            txtMaxLife.Depth = 0;
            txtMaxLife.Hint = "";
            txtMaxLife.Location = new Point(667, 347);
            txtMaxLife.Margin = new Padding(4, 5, 4, 5);
            txtMaxLife.MaxLength = 32767;
            txtMaxLife.MouseState = MaterialSkin.MouseState.HOVER;
            txtMaxLife.Name = "txtMaxLife";
            txtMaxLife.PasswordChar = '\0';
            txtMaxLife.SelectedText = "";
            txtMaxLife.SelectionLength = 0;
            txtMaxLife.SelectionStart = 0;
            txtMaxLife.Size = new Size(294, 32);
            txtMaxLife.TabIndex = 65;
            txtMaxLife.TabStop = false;
            txtMaxLife.UseSystemPasswordChar = false;
            txtMaxLife.KeyPress += txtAttack_KeyPress_1;
            // 
            // btnDeletee
            // 
            btnDeletee.AutoSize = true;
            btnDeletee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeletee.Depth = 0;
            btnDeletee.Icon = null;
            btnDeletee.Location = new Point(1734, 828);
            btnDeletee.Margin = new Padding(6, 7, 6, 7);
            btnDeletee.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeletee.Name = "btnDeletee";
            btnDeletee.Primary = true;
            btnDeletee.Size = new Size(95, 36);
            btnDeletee.TabIndex = 69;
            btnDeletee.Text = "DELETE";
            btnDeletee.UseVisualStyleBackColor = true;
            btnDeletee.Click += btnDeletee_Click;
            // 
            // btnUpdatee
            // 
            btnUpdatee.AutoSize = true;
            btnUpdatee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdatee.Depth = 0;
            btnUpdatee.Icon = null;
            btnUpdatee.Location = new Point(1731, 732);
            btnUpdatee.Margin = new Padding(6, 7, 6, 7);
            btnUpdatee.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdatee.Name = "btnUpdatee";
            btnUpdatee.Primary = true;
            btnUpdatee.Size = new Size(101, 36);
            btnUpdatee.TabIndex = 68;
            btnUpdatee.Text = "UPDATE";
            btnUpdatee.UseVisualStyleBackColor = true;
            btnUpdatee.Click += btnUpdatee_Click;
            // 
            // btnCreatee
            // 
            btnCreatee.AutoSize = true;
            btnCreatee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreatee.Depth = 0;
            btnCreatee.Icon = null;
            btnCreatee.Location = new Point(520, 608);
            btnCreatee.Margin = new Padding(6, 7, 6, 7);
            btnCreatee.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreatee.Name = "btnCreatee";
            btnCreatee.Primary = true;
            btnCreatee.Size = new Size(99, 36);
            btnCreatee.TabIndex = 67;
            btnCreatee.Text = "CREATE";
            btnCreatee.UseVisualStyleBackColor = true;
            btnCreatee.Click += btnCreatee_Click;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(1720, 698);
            materialDivider1.Margin = new Padding(7, 8, 7, 8);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(131, 238);
            materialDivider1.TabIndex = 66;
            materialDivider1.Text = "materialDivider1";
            // 
            // CRUDentity
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1846, 1106);
            Controls.Add(btnDeletee);
            Controls.Add(btnUpdatee);
            Controls.Add(btnCreatee);
            Controls.Add(materialDivider1);
            Controls.Add(txtMaxLife);
            Controls.Add(txtMaxEnergy);
            Controls.Add(txtRange);
            Controls.Add(txtDefense);
            Controls.Add(txtAttack);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(materialLabel10);
            Controls.Add(materialLabel9);
            Controls.Add(materialLabel8);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(clbEnvironments);
            Controls.Add(materialLabel4);
            Controls.Add(picCreature);
            Controls.Add(dgvEntities);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(cbDiet);
            Controls.Add(cbKingdom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "CRUDentity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDentity";
            ((System.ComponentModel.ISupportInitialize)dgvEntities).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCreature).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbKingdom;
        //private TextBox txtName;
        private ComboBox cbDiet;
        //private TextBox txtAttack;
        private DataGridView dgvEntities;
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
        private PictureBox picCreature;
        private CheckedListBox clbEnvironments;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAttack;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDefense;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRange;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaxEnergy;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaxLife;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeletee;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdatee;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreatee;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}