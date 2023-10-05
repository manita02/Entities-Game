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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDfood));
            cbDiet = new ComboBox();
            dgvFoods = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            diet = new DataGridViewTextBoxColumn();
            calories = new DataGridViewTextBoxColumn();
            picDiet = new PictureBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnDeletee = new MaterialSkin.Controls.MaterialRaisedButton();
            btnUpdatee = new MaterialSkin.Controls.MaterialRaisedButton();
            btnCreatee = new MaterialSkin.Controls.MaterialRaisedButton();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCalories = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDiet).BeginInit();
            SuspendLayout();
            // 
            // cbDiet
            // 
            cbDiet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDiet.FormattingEnabled = true;
            cbDiet.Location = new Point(145, 212);
            cbDiet.Margin = new Padding(4);
            cbDiet.Name = "cbDiet";
            cbDiet.Size = new Size(205, 26);
            cbDiet.TabIndex = 38;
            cbDiet.SelectedIndexChanged += cbDiet_SelectedIndexChanged;
            // 
            // dgvFoods
            // 
            dgvFoods.AllowUserToAddRows = false;
            dgvFoods.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Columns.AddRange(new DataGridViewColumn[] { id, name, diet, calories });
            dgvFoods.Location = new Point(0, 398);
            dgvFoods.Margin = new Padding(4);
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFoods.RowHeadersVisible = false;
            dgvFoods.RowTemplate.Height = 25;
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.Size = new Size(871, 266);
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
            // picDiet
            // 
            picDiet.Location = new Point(445, 78);
            picDiet.Margin = new Padding(4);
            picDiet.Name = "picDiet";
            picDiet.Size = new Size(446, 303);
            picDiet.SizeMode = PictureBoxSizeMode.StretchImage;
            picDiet.TabIndex = 44;
            picDiet.TabStop = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel4.Location = new Point(48, 252);
            materialLabel4.Margin = new Padding(5, 0, 5, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(69, 19);
            materialLabel4.TabIndex = 48;
            materialLabel4.Text = "Calories:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(80, 212);
            materialLabel3.Margin = new Padding(5, 0, 5, 0);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(40, 19);
            materialLabel3.TabIndex = 47;
            materialLabel3.Text = "Diet:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(67, 173);
            materialLabel2.Margin = new Padding(5, 0, 5, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(53, 19);
            materialLabel2.TabIndex = 46;
            materialLabel2.Text = "Name:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(99, 135);
            materialLabel1.Margin = new Padding(5, 0, 5, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(25, 19);
            materialLabel1.TabIndex = 45;
            materialLabel1.Text = "Id:";
            // 
            // btnDeletee
            // 
            btnDeletee.AutoSize = true;
            btnDeletee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeletee.Depth = 0;
            btnDeletee.Icon = null;
            btnDeletee.Location = new Point(880, 476);
            btnDeletee.Margin = new Padding(4);
            btnDeletee.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeletee.Name = "btnDeletee";
            btnDeletee.Primary = true;
            btnDeletee.Size = new Size(69, 36);
            btnDeletee.TabIndex = 52;
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
            btnUpdatee.Location = new Point(878, 418);
            btnUpdatee.Margin = new Padding(4);
            btnUpdatee.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdatee.Name = "btnUpdatee";
            btnUpdatee.Primary = true;
            btnUpdatee.Size = new Size(73, 36);
            btnUpdatee.TabIndex = 51;
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
            btnCreatee.Location = new Point(144, 295);
            btnCreatee.Margin = new Padding(4);
            btnCreatee.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreatee.Name = "btnCreatee";
            btnCreatee.Primary = true;
            btnCreatee.Size = new Size(71, 36);
            btnCreatee.TabIndex = 50;
            btnCreatee.Text = "CREATE";
            btnCreatee.UseVisualStyleBackColor = true;
            btnCreatee.Click += btnCreatee_Click;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(870, 398);
            materialDivider1.Margin = new Padding(5);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(92, 143);
            materialDivider1.TabIndex = 49;
            materialDivider1.Text = "materialDivider1";
            // 
            // txtName
            // 
            txtName.Depth = 0;
            txtName.Hint = "";
            txtName.Location = new Point(145, 173);
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.HOVER;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(206, 23);
            txtName.TabIndex = 54;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Hint = "";
            txtId.Location = new Point(144, 131);
            txtId.MaxLength = 32767;
            txtId.MouseState = MaterialSkin.MouseState.HOVER;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(205, 23);
            txtId.TabIndex = 53;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtCalories
            // 
            txtCalories.Depth = 0;
            txtCalories.Hint = "";
            txtCalories.Location = new Point(145, 252);
            txtCalories.MaxLength = 32767;
            txtCalories.MouseState = MaterialSkin.MouseState.HOVER;
            txtCalories.Name = "txtCalories";
            txtCalories.PasswordChar = '\0';
            txtCalories.SelectedText = "";
            txtCalories.SelectionLength = 0;
            txtCalories.SelectionStart = 0;
            txtCalories.Size = new Size(206, 23);
            txtCalories.TabIndex = 55;
            txtCalories.TabStop = false;
            txtCalories.UseSystemPasswordChar = false;
            // 
            // CRUDfood
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(963, 667);
            Controls.Add(txtCalories);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnDeletee);
            Controls.Add(btnUpdatee);
            Controls.Add(btnCreatee);
            Controls.Add(materialDivider1);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(picDiet);
            Controls.Add(dgvFoods);
            Controls.Add(cbDiet);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "CRUDfood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDfood";
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDiet;
        private DataGridView dgvFoods;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn diet;
        private DataGridViewTextBoxColumn calories;
        private PictureBox picDiet;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeletee;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdatee;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreatee;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalories;
    }
}