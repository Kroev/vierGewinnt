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

        Spielfeld(int height, int width)
        {
            felder = new int [height, width];

            for (int x = 0; x < height; x++)
            {
                for(int y = 0; y < width; y++)
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
        public int felderSetzen(int x, int y, int wert)
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
            if (x > (felder.GetLength(0) - 1))
            {
                return false;
            }
            else if (y > (felder.GetLength(1) - 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
