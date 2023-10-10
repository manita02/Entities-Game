using crudsGame.src.controllers;

namespace crudsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ItemController entityCtn;
            entityCtn = ItemController.getInstance();

        }
        private ComboBox comboBox1;



        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Name = "Form1";
            ResumeLayout(false);
        }
    }
}