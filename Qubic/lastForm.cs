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
        public event EventHandler<bool> closedLast;
        public lastForm(string player, int result)
        {
            InitializeComponent();
            if (result == -1)
                nameWinner.Text = "Igra je završila neriješeno!";
            else
                nameWinner.Text += player;
        }

        private void lastForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closedLast != null) closedLast(this,true);
        }
    }
}
