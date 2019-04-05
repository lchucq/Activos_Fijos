using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activosFijos
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
            Application.Run(new Form1());
        }
        public static class Globals
        {
            private static string _name;
            public static string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            private static string _cod;
            public static string Usuario
            {
                get { return _cod; }
                set { _cod = value; }
            }
            private static string _email;
            public static string email
            {
                get { return _email; }
                set { _email = value; }
            }
            private static string _codUsu;
            public static string codUsu
            {
                get { return _codUsu; }
                set { _codUsu = value; }
            }
        }
    }
}
