using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vierGewinnt
{
    class VGButton : Button
    {
        private int column;
        public VGButton(int column) : base()
        {
            this.column = column;
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
