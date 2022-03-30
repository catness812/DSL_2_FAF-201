using System.Text;

namespace GraphicsForLDSL
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
            int applies = 2, angle = 45, length = 10;
            var builder = new StringBuilder("ff[+f[+X][-X]X][-f[+X][-X]X]f[+X][-X]X");
            string rule = builder.ToString();
            var form = new Form1(applies, angle, length, rule);
            Application.Run(form);
        }
    }
}