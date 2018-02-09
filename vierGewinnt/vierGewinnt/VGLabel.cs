using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vierGewinnt
{
    class VGLabel : Label
    {
        private int row;
        private int column;
        public VGLabel(int row, int column) : base()
        {
            this.row = row;
            this.column = column;
        }

        public int Row
        {
            get
            {
                return row;
            }
        }

        public int Column
        {
            get
            {
                return column;
            }
        }
    }
}
