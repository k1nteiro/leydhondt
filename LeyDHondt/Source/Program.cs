using LeyDHondt.Forms;
using System;
using System.Windows.Forms;

namespace LeyDHondt
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Aquí se abre el formulario MainForm
        }
    }
}
