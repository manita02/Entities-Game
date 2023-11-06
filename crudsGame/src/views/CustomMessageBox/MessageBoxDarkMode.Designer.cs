namespace crudsGame.src.views
{
    partial class MessageBoxDarkMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxDarkMode));
            panel2 = new Panel();
            btnCancel = new Button();
            btnConfirm = new Button();
            lblMessage = new Label();
            pictureBoxImage = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 39, 42);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(lblMessage);
            panel2.Controls.Add(pictureBoxImage);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 230);
            panel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(35, 39, 42);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(370, 178);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 38);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(35, 39, 42);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Location = new Point(136, 178);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(88, 38);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Ok";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Visible = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(164, 19);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(458, 149);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Message";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImage.Location = new Point(8, 24);
            pictureBoxImage.Margin = new Padding(3, 2, 3, 2);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(146, 135);
            pictureBoxImage.TabIndex = 1;
            pictureBoxImage.TabStop = false;
            // 
            // MessageBoxDarkMode
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(634, 230);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MessageBoxDarkMode";
            Text = "MessageBoxDarkMode";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lblMessage;
        private PictureBox pictureBoxImage;
    }
}