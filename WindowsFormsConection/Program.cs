using System;
using System.Windows.Forms;

namespace WindowsFormsConection
{
    internal static class Program
    {
        // Campo estático y de solo lectura válido en una clase estática.
        // Si la variable de entorno no está establecida, se usa cadena vacía.
        public static string Password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? string.Empty;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());
        }
    }
}
