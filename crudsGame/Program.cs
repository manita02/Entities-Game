using crudsGame.src.views;

namespace crudsGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new CRUDitem());
            //Application.Run(new CRUDentity());
            //Application.Run(new AttackTest());
            //Application.Run(new MapTest());
            //Application.Run(new CRUDfood());
            Application.Run(new Menu());

        }
    }
}