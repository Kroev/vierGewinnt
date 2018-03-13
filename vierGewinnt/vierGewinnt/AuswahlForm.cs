using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vierGewinnt
{
    public partial class AuswahlForm : Form
    {
        /**
         * AuswahlForm Konstruktor
         */
        public AuswahlForm() : base() 
        {
            InitializeComponent();
        }
        
        /**
         * Button Listener für Enter in AuswahlForm für neues Spiel starten
         */
        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newGame();
            }
        }

        /**
         * Klick auf Ok Button um ein neues Spiel zu starten
         */
        private void btnOk_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            newStatistic();
        }

        /**
         * Funktion um ein neues Spiel zu starten.
         * Funktion erzeugt neues Spiel, hier wird neue SpielForm erzeugt und Spielernamen übergeben.
         * Bei Schließen des SpielForms wird per MessageBox der Neustart angefragt.
         */
        private void newGame()
        {
            String sp1 = txbName1.Text;
            String sp2 = txbName2.Text;
            Regex regex = new Regex("^[A-Za-z]{1,15}$"); // was zugelassen wird ^anfang string $ ende string (verhindert codeeingaben)
            if (sp1 == "" || sp2 == "") // wenn nichts eingegeben wird 
            {
                MessageBox.Show("Mindestens eine der beiden Eingaben ist leer."); //show
            }
            else if (sp1==sp2)
            {
                MessageBox.Show("Beide Spieler dürfen nicht den selben Namen haben");
            }
            else if (!(regex.IsMatch(sp1)) || !(regex.IsMatch(sp2)))
            {
                MessageBox.Show("Die Zeicheneingabe ist Fehlerhaft." +
                    "Nur 15 Zeichen A-Z ohne Leerzeichen sind erlaubt.");
            }
            else
            {
                this.Hide();
                SpielForm spf = new SpielForm(sp1, sp2);
                spf.ShowDialog();// macht spielform sichtbar
                const string message = "Wollen Sie ein neues Spiel beginnen?";
                const string caption = "Neues Spiel";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.Yes)
                {
                    // Zeigt wieder Auswahlform
                    this.Show();
                }
                else
                {
                    //schließt Auswahlform
                    this.Close();
                }
            }
        }
        private void newStatistic()
        {
            StatistikForm stf = new StatistikForm();
            stf.ShowDialog();// macht spielform sichtbar
        }
    }
}

