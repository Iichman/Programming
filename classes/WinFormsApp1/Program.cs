using System;
using System.Windows.Forms;
using Programming.View; // ѕрив€зка к пространству имен, где находитс€ MainForm

namespace WinFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // «десь запуститс€ ваше главное окно
        }
    }
}