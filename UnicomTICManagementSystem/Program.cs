using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Views;

namespace UnicomTICManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseManager.CreateTable();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Loginform());
        }
    }
}