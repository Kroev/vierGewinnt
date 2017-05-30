using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace vierGewinnt
{
    static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole();

            //test insert token into column
            Spielfeld spielfeld = new Spielfeld(5, 3);
            spielfeld.print();
            spielfeld.feldSetzen(0, 1);
            spielfeld.print();
            spielfeld.feldSetzen(0, 2);
            spielfeld.feldSetzen(0, 3);
            spielfeld.feldSetzen(0, 4);
            spielfeld.feldSetzen(0, 5);
            spielfeld.print();
            int test = spielfeld.feldSetzen(0, 6);
            Console.WriteLine("trying to insert anotherone into column 0, if -2 -> OK: " + test);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SpielForm());
        }
    }
}
