using System;
using System.Windows.Forms;

namespace StockManagement.UI
{
    internal static class Program
    {
        [STAThread] // Nécessaire pour les applications WinForms
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm()); // Assurez-vous que MainMenuForm est le bon nom de votre formulaire principal
        }
    }
}
