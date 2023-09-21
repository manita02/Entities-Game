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
            /*
            entityCtn = MassiveItemCreator.getInstance();
            comboBox1.DataSource = entityCtn.CreateItemsMassively();
            */


        }
    }
}