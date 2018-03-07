using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

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
            int eloyellow;
            int elored;

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

            //test horizontale gewinnermittlung
            Spielsteuerung control = new Spielsteuerung(7, 6, "red", "yellow");
            control.setgelbElo(800);
            control.setRotElo(1000);
            for (int i = 0; i < 5; i++)
            {
                control.spielzug(i);
                control.spielzug(i);
            }
            control.Spielfeld.print();
            Console.WriteLine("Spielende sollte jetzt auf 1 stehen: spielende = " + control.Spielende);
            Console.WriteLine("Elo Spieler1: " + control.getGelbElo());
            Console.WriteLine("Elo Spieler2: " + control.getRotElo());
            eloyellow = control.getGelbElo();
            elored = control.getRotElo();

            //vertikale gewinnermittlung
            control = new Spielsteuerung(7, 6, "red", "yellow");
            control.setgelbElo(eloyellow);
            control.setRotElo(elored);
            control.spielzug(0);
            for(int j =0; j < 8; j++)
            {
                control.spielzug(1);
                control.spielzug(2);
            }
            control.Spielfeld.print();
            Console.WriteLine("Spielende sollte jetzt auf 2 stehen: spielende = " + control.Spielende);
            Console.WriteLine("Elo Spieler1: " + control.getGelbElo());
            Console.WriteLine("Elo Spieler2: " + control.getRotElo());
            eloyellow = control.getGelbElo();
            elored = control.getRotElo();

            //diagonale 1 gewinnermittlung
            control = new Spielsteuerung(7, 6, "red", "yellow");
            control.setgelbElo(eloyellow);
            control.setRotElo(elored);
            for (int k = 0; k < 8; k++)
            {
                control.spielzug(k);
                control.spielzug(k + 1);
                control.spielzug(k + 2);
                control.spielzug(k + 3);
            }
            control.Spielfeld.print();
            Console.WriteLine("Spielende sollte jetzt auf 1 stehen: spielende = " + control.Spielende);
            Console.WriteLine("Elo Spieler1: " + control.getGelbElo());
            Console.WriteLine("Elo Spieler2: " + control.getRotElo());
            eloyellow = control.getGelbElo();
            elored = control.getRotElo();

            //diagonale 2 gewinnermittlung
            control = new Spielsteuerung(7, 6, "red", "yellow");
            control.setgelbElo(eloyellow);
            control.setRotElo(elored);
            for (int k = 6; k > -1; k--)
            {
                control.spielzug(k);
                control.spielzug(k - 1);
                control.spielzug(k - 2);
                control.spielzug(k - 3);
            }
            control.Spielfeld.print();
            Console.WriteLine("Spielende sollte jetzt auf 1 stehen: spielende = " + control.Spielende);
            Console.WriteLine("Elo Spieler1: " + control.getGelbElo());
            Console.WriteLine("Elo Spieler2: " + control.getRotElo());
            eloyellow = control.getGelbElo();
            elored = control.getRotElo();

            //remisermittlung
            control = new Spielsteuerung(7, 6, "red", "yellow");
            control.setgelbElo(eloyellow);
            control.setRotElo(elored);
            for (int i = 0; i < 6; i++)
            {
                control.spielzug(0);
            }
            for (int i = 0; i < 6; i++)
            {
                control.spielzug(1);
            }
            for (int i = 0; i < 6; i++)
            {
                control.spielzug(4);
            }
            for (int i = 0; i < 6; i++)
            {
                control.spielzug(5);
            }
            for (int i = 0; i < 6; i++)
            {
                control.spielzug(6);
            }
            control.spielzug(2);
            control.spielzug(3);
            control.spielzug(3);
            control.spielzug(2);
            control.spielzug(2);
            control.spielzug(3);
            control.spielzug(3);
            control.spielzug(2);
            control.spielzug(2);
            control.spielzug(3);
            control.spielzug(3);
            control.spielzug(2);
            control.Spielfeld.print();
            Console.WriteLine("Spielende sollte jetzt auf -2 stehen: spielende = " + control.Spielende);
            Console.WriteLine("Elo Spieler1: " + control.getGelbElo());
            Console.WriteLine("Elo Spieler2: " + control.getRotElo());
            Hashtable table = new Hashtable();
            table["name"] = "Ronny";
            table["elo"] = "789";
            List<Hashtable> liste = new List<Hashtable>();
            liste.Add((Hashtable)table.Clone());
            table["name"] = "Julian";
            table["elo"] = "666";
            liste.Add((Hashtable)table.Clone());
            table["name"] = "Simon";
            table["elo"] = "456";
            liste.Add((Hashtable)table.Clone());
            table["name"] = "Kevin";
            table["elo"] = "354";
            liste.Add((Hashtable)table.Clone());
            table["name"] = "Axel";
            table["elo"] = "890";
            liste.Add((Hashtable)table.Clone());
            table["name"] = "Jessica";
            table["elo"] = "1002";
            liste.Add((Hashtable)table.Clone());
            table["name"] = "Till";
            table["elo"] = "364";
            liste.Add((Hashtable)table.Clone());
            foreach (Hashtable itable in liste) {
                Console.Write(itable["name"]);
                Console.Write(" ");
                Console.WriteLine(itable["elo"]);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StatistikForm());
        }
    }
}
