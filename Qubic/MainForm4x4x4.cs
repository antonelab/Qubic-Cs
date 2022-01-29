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
        private database db;
        public event EventHandler<Tuple<int, int, int>> btnClicked;
        private String xPlayer, oPlayer;

        public MainForm4x4x4(string xPlayer, string oPlayer)
        {
            this.xPlayer = xPlayer;
            this.oPlayer = oPlayer;
            InitializeComponent();
            SuspendLayout();
            db = new database();

            level4Form1.btnClicked += (sender, e) => btnClicked(sender, Tuple.Create(0, e.Item1, e.Item2));
            level4Form2.btnClicked += (sender, e) => btnClicked(sender, Tuple.Create(0, e.Item1, e.Item2));
            level4Form3.btnClicked += (sender, e) => btnClicked(sender, Tuple.Create(0, e.Item1, e.Item2));
            level4Form4.btnClicked += (sender, e) => btnClicked(sender, Tuple.Create(0, e.Item1, e.Item2));
            ResumeLayout();
            xNameLabel.Text = "IME: " + xPlayer;
            oNameLabel.Text = "IME: " + oPlayer;

            //za kompjuter moramo zablokirat statistiku i predaju
            if (xPlayer.Equals("kompjuter"))
            {
                statMenu.DropDownItems[0].Enabled = false;
                closeMenu.DropDownItems[0].Enabled = false;
            }
            if (oPlayer.Equals("kompjuter"))
            {
                statMenu.DropDownItems[1].Enabled = false;
                closeMenu.DropDownItems[1].Enabled = false;
            }
        }

        public void rulesMenuClicked(object sender, EventArgs e)
        {
            var p = new RulesForm();
            p.Show();
        }

        private void xStatMenu_Click(object sender, EventArgs e)
        {
            var p = new StatForm(xPlayer);
            p.Show();
        }

        private void resultsMenu_Click(object sender, EventArgs e)
        {
            var p = new TopResultsForm();
            p.Show();
        }

        private void oStatMenu_Click(object sender, EventArgs e)
        {
            var p = new StatForm(oPlayer);
            p.Show();
        }
    }
}
