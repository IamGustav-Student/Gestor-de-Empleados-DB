using System;
using System.Windows.Forms;

namespace GestorEmpleados
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Iniciar con LoginForm (como en el PDF)
            Application.Run(new LoginForm());
        }
    }
}