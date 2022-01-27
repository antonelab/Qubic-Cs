using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qubic
{
    public partial class MainForm4x4x4 : Gui
    {

        public event EventHandler<Tuple<int, int, int>> btnClicked;
        public MainForm4x4x4()
        {
            InitializeComponent();
            level4Form1.btnClicked += (sender, e) => btnClicked(sender, Tuple.Create(0, e.Item1, e.Item2));
            level4Form2.btnClicked += (sender, e) => btnClicked(sender, Tuple.Create(0, e.Item1, e.Item2));
            level4Form3.btnClicked += (sender, e) => btnClicked(sender, Tuple.Create(0, e.Item1, e.Item2));
            level4Form4.btnClicked += (sender, e) => btnClicked(sender, Tuple.Create(0, e.Item1, e.Item2));
        }
    }
}
