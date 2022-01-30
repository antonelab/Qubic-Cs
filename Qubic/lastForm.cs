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
    public partial class lastForm : Form
    {
        public lastForm(string player, int result)
        {
            InitializeComponent();
            if (result == -1)
                nameWinner.Text = "Igra je završila nerješeno!";
            else
                nameWinner.Text += player;
        }
    }
}
