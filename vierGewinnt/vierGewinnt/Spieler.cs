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
        int elo;

        public Spieler (String name, int wert, int elo)
        {
            this.name = name;
            this.wert = wert;
            this.elo = elo;
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
