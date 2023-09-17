using crudsGame.src.controllers;
using crudsGame.src.model.Items.Strategy;

namespace crudsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MassiveItemCreator entityCtn;
            entityCtn = MassiveItemCreator.getInstance();
            
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