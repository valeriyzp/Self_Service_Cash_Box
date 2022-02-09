using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Service_Cash_Box
{
    class ButtonForTableClass : Button
    {
        public ButtonForTableClass(int Row, int Column)
        {
            this.Row = Row;
            this.Column = Column;
        }

        public int Row, Column;
    }
}
