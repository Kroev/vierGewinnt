using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vierGewinnt
{
    class Spielfeld
    {
        private VGLabel[,] felder;

        Spielfeld(int height, int width)
        {
            this.felder = new VGLabel[height, width];
        }

    }
}
