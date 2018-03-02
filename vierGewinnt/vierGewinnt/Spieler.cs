using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vierGewinnt
{
    class Spieler
    {
        String name;
        int wert;
        int elo=600;

        public Spieler (String name, int wert)
        {
            this.name = name;
            this.wert = wert;
        }

        public int Elo
        {
            get
            {
                return elo;
            }

            set
            {
                elo = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
