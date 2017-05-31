using System;
using System.Collections.Generic;
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
        private int spielende;

        /**
         * Erzeugt eine neue Spielsteuerung mit einem Spielfeld mit der angegebenen Höhe
         * 
         * \param width Breite des zu erzeugenden Spielfeldes 
         * \param height Höhe des zu erzeugenden Spielfeldes
         */
        public Spielsteuerung (int width, int height)
        {
            this.spielfeld = new Spielfeld(height, width);
            this.gelb = new Spieler("Spieler1", 1);
            this.rot = new Spieler("Spieler2", 2);
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
         */
        public int spielzug(int column)
        {
            int result = this.spielfeld.feldSetzen(column, this.akt);
            if ( result >= 0 )
            {
                int x = column;
                int y = result;
                int gewinn = this.gewinnermittlung(x, y);
                if (gewinn > 0)
                {
                    this.spielende = this.akt;
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
                while ((this.spielfeld.getByCoordinates(x - i, y + i) == wert)
                    && streak < winningCondition)
                {
                    streak++;
                    i++;
                }
                if (streak >= winningCondition)
                {
                    return 1;
                }

                return 0;

            }
            else
            {
                return wert;
            }
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

        internal Spielfeld Spielfeld
        {
            get
            {
                return spielfeld;
            }
        }
    }
}
