using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vierGewinnt
{
    class Spielsteuerung
    {
        private Spielfeld spielfeld;
        private Spieler gelb; //Spieler 1 von Wert her
        private Spieler rot; //Spieler 2 von Wert her
        private int akt;
        private int spielende; //0 -> spiel läuft; akt -> gewonnen, -2 -> remis
        private DataTable hashtabelle;

        /**
         * Erzeugt eine neue Spielsteuerung mit einem Spielfeld mit der angegebenen Höhe
         * 
         * \param width Breite des zu erzeugenden Spielfeldes 
         * \param height Höhe des zu erzeugenden Spielfeldes
         */
        public Spielsteuerung (int width, int height, String name1, String name2)
        {
            this.spielfeld = new Spielfeld(height, width);
            this.Spieleranlegen(name1, name2);
            this.akt = 1;
            this.spielende = 0;
        }

        /**
         * Macht einen Spielzug, indem ein Spielstein des aktuellen Spielers
         * in die angegebene Spalte eingeworfen wird.
         * 
         * \param column Spalte in die der Spielstein eingeworfen werden soll
         * 
         * \return y-Koordinate des eingeworfenen Spielsteins
         * \return -1 coulumn out of range
         * \return -2 column already full
         * \return -3 game already over
         */
        public int spielzug(int column)
        {
            if ( this.spielende != 0 )
            {
                return -3;
            }

            int result = this.spielfeld.feldSetzen(column, this.akt);
            if ( result >= 0 )
            {
                int x = column;
                int y = result;
                int gewinn = this.gewinnermittlung(x, y);
                if (gewinn > 0)
                {
                    this.spielende = this.akt;
                    //elorechnung
                    elorechnung(this.spielende);
                    //update db funktion
                }
                else if ( gewinn == -2 )
                {
                    this.spielende = -2;
                    //elorechnung
                    elorechnung(this.spielende);
                }
                else
                {
                    //Spieler flicken
                    if ( this.akt == 1 )
                    {
                        this.akt = 2;
                    }
                    else
                    {
                        this.akt = 1;
                    }
                }
            }

            return result;
        }

        /**
         * ermittelt, ob der Stein auf XY eine Gewinnfigur bildet
         * 
         * \param x X-Koordinate des letzten Spielsteins
         * \param y Y-Koordinate des letzten Spielsteins
         * 
         * \return 0 kein Gewinn
         * \return 1 Gewinn
         * \return -1 Fehler, XY out of range
         * \return -2 Remis
         */
        private int gewinnermittlung (int x, int y)
        {
            int wert = this.spielfeld.getByCoordinates(x, y);
            int winningCondition = 4;
            if ( wert > 0 )
            {
                //Horizontale
                int i = 1;
                int streak = 1;
                while ((this.spielfeld.getByCoordinates(x + i, y) == wert) 
                    && streak < winningCondition)
                {
                    streak++;
                    i++;
                }
                i = 1;
                while ((this.spielfeld.getByCoordinates(x - i, y) == wert)
                    && streak < winningCondition)
                {
                    streak++;
                    i++;
                }
                if (streak >= winningCondition)
                {
                    return 1;
                }

                //Vertikale
                i = 1;
                streak = 1;
                while ((this.spielfeld.getByCoordinates(x, y + i) == wert)
                    && streak < winningCondition)
                {
                    streak++;
                    i++;
                }
                i = 1;
                while ((this.spielfeld.getByCoordinates(x, y - i) == wert)
                    && streak < winningCondition)
                {
                    streak++;
                    i++;
                }
                if (streak >= winningCondition)
                {
                    return 1;
                }

                //Diagonale1
                i = 1;
                streak = 1;
                while ((this.spielfeld.getByCoordinates(x + i, y + i) == wert)
                    && streak < winningCondition)
                {
                    streak++;
                    i++;
                }
                i = 1;
                while ((this.spielfeld.getByCoordinates(x - i, y - i) == wert)
                    && streak < winningCondition)
                {
                    streak++;
                    i++;
                }
                if (streak >= winningCondition)
                {
                    return 1;
                }

                //Diagonale2
                i = 1;
                streak = 1;
                while ((this.spielfeld.getByCoordinates(x - i, y + i) == wert)
                    && streak < winningCondition)
                {
                    streak++;
                    i++;
                }
                i = 1;
                while ((this.spielfeld.getByCoordinates(x + i, y - i) == wert)
                    && streak < winningCondition)
                {
                    streak++;
                    i++;
                }
                if (streak >= winningCondition)
                {
                    return 1;
                }

                //test for remis
                if ( this.spielfeld.isfull() )
                {
                    //if we reach this point and spielfeld is full => remis
                    return -2;
                }

                return 0;

            }
            else
            {
                return wert;
            }
        }

        public int elorechnung(int winner)
        {
            float eloaltgelb = gelb.Elo;
            float eloaltrot = rot.Elo;
            float eloneugelb;
            float eloneurot;
            float winloose = 0;
            float K = 32;
            float C = 200;
            float a = 1; //setzen a=1 als float zur korrekten Berechnung der Werte
            float b = 2; //setzen b=2 als float zur korrekten Berechnung der Werte

            switch (winner)
            {
                case 1:
                    winloose = 1;
                    break;
                case 2:
                    winloose = -1;
                    break;
                case -2:
                    winloose = 0;
                    break;
                default:
                    return -1;
            }
            eloneugelb = eloaltgelb + (K / b) * (winloose + (a / b) * ((eloaltrot - eloaltgelb) / C));
            eloneurot = eloaltrot + (K / b) * (-a*winloose + (a / b) * ((eloaltgelb - eloaltrot) / C));
            gelb.Elo = (int)eloneugelb;
            rot.Elo = (int)eloneurot;
            return 0;


        }

        public DataTable Statistikholen()
        {
            hashtabelle = new DataTable();
            //hashtabelle = funktion von kevin
            return hashtabelle;
        }

        public int Spieleranlegen(String namegelb, String namerot)
        {
            int angelegt = 0;
            int defelo = 600;
            Hashtable usertable = new Hashtable();

            //gelben Spieler in DB und als Spieler anlegen
            angelegt = DBConnector.newplayer(namegelb,defelo);
            if (angelegt == 1)
            {
                usertable = DBConnector.getplayer(namegelb);
                this.gelb = new Spieler(namegelb, 1, (int)usertable["elo"]);
            }
            else
            {
                this.gelb = new Spieler(namegelb, 1, defelo);
            }

            //roten Spieler in DB und als Spieler anlegen
            angelegt = DBConnector.newplayer(namerot, defelo);
            if (angelegt == 1)
            {
                usertable = DBConnector.getplayer(namerot);
                this.gelb = new Spieler(namerot, 1, (int)usertable["elo"]);
            }
            else
            {
                this.gelb = new Spieler(namerot, 1, defelo);
            }

            return 0;
        }

        public int Spielende
        {
            get
            {
                return spielende;
            }
        }

        public int Akt
        {
            get
            {
                return akt;
            }
        }

        //abstraction of Spieler object
        public String getRotName ()
        {
            return this.rot.Name;
        }
        public String getGelbName ()
        {
            return this.gelb.Name;
        }

        public int getRotElo ()
        {
            return this.rot.Elo;
        }
        public int getGelbElo ()
        {
            return this.gelb.Elo;
        }
    }
}
