using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vierGewinnt
{
    class Spielfeld
    {
        private int[,] felder;

        /******** Coordinate System **************
         * 0|0 1|0   ...  width-1|0
         * 0|1    .              .
         *  .          .         .
         *  .              .     .
         * 0|height-1 ... width-1|height-1
         * ***************************************/

        /**
         *Erzeugt ein neues Spielfeld mit der gewünschten Höhe und Breite.
         * 
         * \param height Höhe für das Spielfeld
         * 
         * \param width Breite des Sielfeldes
         */
        public Spielfeld(int height, int width)
        {
            felder = new int [width, height];

            for (int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    felder[x, y] = 0;
                }
            }
        }

        /** Gibt den Wert des jeweiligen Labels zurück
         * 
         * \param   x       Zeile des VGLabel's
         * \param   y       Spalte des VGLabel's
         * 
         * \return  2       Label von Spieler 2
         * \return  1       Label von Spieler 1
         * \return  0       Label ist weiß
         * \return  -1      Koordinaten sind außerhalb des Spielfeldes
         * 
        */
        public int getByCoordinates(int x, int y)
        {
            if (this.testCoordinates(x, y) == false)
            {
                return -1; 
            }
            
            else
            {
                return felder[x, y];
            }
        }

        /** Setzt den Wert des zugehörigen Label's fest
         * 
         * \param   x       Zeile des VGLabel's
         * \param   y       Spalte des VGLabel's
         * \param   wert    Wert des Labels 
         * 
         * \return  0       Wersetzung ist richtig verlaufen
         * \return  -1      Koordinaten sind außerhalb des Spielfeldes
        */
        private int feldSetzen(int x, int y, int wert)
        {
            if(this.testCoordinates(x,y)== false)
            {
                return -1; 
            }
            else
            {
                felder[x, y] = wert;
                return 0;
            }
        }

        /**
         * Drops a token into the grid so that it takes the first free slot from bottom up.
         * Does this only if the column has at least one free slot of course.
         * 
         * \param column The column where the token is to be inserted
         * \param wert the value associated with the player who inserted this token
         * 
         * \return y-coordinate of the new token
         * \return -1 if column or coordinate is out of range
         * \return -2 if column is full
         */
        public int feldSetzen(int column, int wert)
        {
            int x = column;
            int y = 0;

            //check if column is full:
            if ( this.testCoordinates(x, y) && (this.getByCoordinates(x,y) == 0))
            {
                //column has at least one field left, determine the row
                //for the field to be set:
                while ( this.testCoordinates(x, (y)) && (this.getByCoordinates(x, (y + 1)) == 0))
                {
                    y++;
                }

                if ( this.feldSetzen(x, y, wert) == 0 )
                {
                    return y;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                //column is full or coordinates out of range!
                //double check :( 
                if ( this.testCoordinates(x,y) )
                {
                    return -2; //full
                }
                else
                {
                    return -1; //was fault of column out of range
                }
            }
        }

        /**
         *An internal function only, used for checking if given coordinates are within range
         * 
         * \param x x-coordinate
         * \param y y-coordinate
         * 
         * \return true if within range
         * \return false if out of range
         */
        private bool testCoordinates(int x, int y)
        {
            if ((x > (felder.GetLength(0) - 1))||(x<0))
            {
                return false;
            }
            else if ((y > (felder.GetLength(1) - 1))||(y<0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /**
         * Gibt den Inhalt des Spielfeldes einfach auf der Konsole aus
         */
        public int print()
        {
            for(int y = 0; y < felder.GetLength(1); y++)
            {
                for (int x = 0; x < felder.GetLength(0); x++)
                {
                    Console.Write(felder[x, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            return 0;
        }
    }
}
