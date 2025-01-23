using System;
using System.Windows.Forms;

namespace TelemetryGroundStation // Certifique-se de que o namespace corresponde ao do Form1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Certifique-se de que o nome é "Form1"
        }
    }
}
