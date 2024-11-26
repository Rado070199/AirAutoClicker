using AirAutoClicker.Forms;
using AirAutoClicker.Presenters;
using AirAutoClicker.Repositories;

namespace AirAutoClicker
{
    public static class Program
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
            IMainForm mainForm = new MainForm();
            IJsonSettingsRepository jsonSettingsRepository = new JsonSettingsRepository();
            MainFormPresenter presenter = new MainFormPresenter(mainForm, jsonSettingsRepository);
            Application.Run((Form)mainForm);
        }
    }
}