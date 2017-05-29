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
        }

        public int getByCoordinates(int x, int y)
        {
            if (this.testCoordinates(x, y) == false)
            {
                return null;
            }
            
            else
            {
                return felder[x, y];
            }
        }

        public int felderSetzen(int x, int y, int wert)
        {
            felder[x, y] = wert;
        }

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
