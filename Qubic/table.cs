using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Qubic
{
    public class table : UserControl
    {
        public event EventHandler<Move> btnClicked;

        public void setEvents(int type)
        {
            for(int i = 1 ; i <= type; i++)
            {
                string lName = "l4Form" + i;
                int ii = i - 1;
                ((level4Control)this.Controls[lName]).btnClicked += (sender, e) => 
                    {
                        if (btnClicked != null)
                            btnClicked(sender, new Qubic.Move(ii, e.Item1, e.Item2));
                    };
            }
        }

        public void setColor(Tuple<int, int, int> tuple, Color color)
        {
            string lName = "l4Form" + (tuple.Item1 + 1);
            string bName = "b" + tuple.Item2 + tuple.Item3;
            if(color != default(Color))
                ((Button)((level4Control)this.Controls[lName])[bName]).BackColor = color;
            else
                ((Button)((level4Control)this.Controls[lName])[bName]).UseVisualStyleBackColor = true;
        }

        public void clickButton (Tuple<int, int, int> tuple)
        {
            string lName = "l4Form" + (tuple.Item1 + 1);
            string bName = "b" + tuple.Item2 + tuple.Item3;
            Button btn = (Button)((level4Control)this.Controls[lName])[bName];
            if (btn.InvokeRequired)
            {
                Action safeWrite = delegate { clickButton(tuple); };
                btn.Invoke(safeWrite);
            }
            else
                btn.PerformClick();
            
        }
    }
}
