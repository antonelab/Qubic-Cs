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
    public partial class TopResultsForm : Form
    {
        private database db;
        public TopResultsForm()
        {
            InitializeComponent();
            db = new database();
            xTop3.Text = db.topPlayers("X", "3x3x3");
            oTop3.Text = db.topPlayers("O", "3x3x3");
            xTop4.Text = db.topPlayers("X", "4x4x4");
            oTop4.Text = db.topPlayers("O", "4x4x4");
        }
    }
}
