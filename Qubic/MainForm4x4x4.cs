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


        public MainForm4x4x4(string xPlayer, string oPlayer) : base(4)
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
            level4Form1.btnClicked += (sender, e) => { hintButton.Enabled = false; raiseBtnClicked(sender, e, 0); };
            level4Form2.btnClicked += (sender, e) => raiseBtnClicked(sender, e, 1);
            level4Form3.btnClicked += (sender, e) => raiseBtnClicked(sender, e, 2);
            level4Form4.btnClicked += (sender, e) => raiseBtnClicked(sender, e, 3);
            newHint += handleHint;
            ResumeLayout();
            xNameLabel.Text = "IME: " + xPlayer;
            oNameLabel.Text = "IME: " + oPlayer;
            hintButton.Enabled = false;
        }

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

        public void handleHint(object sender, Move e)
        {
            if (hintButton.InvokeRequired)
            {
                Action safeWrite = delegate { handleHint(sender, e); };
                hintButton.Invoke(safeWrite);
            }
            else
                hintButton.Enabled = true;
        }

        public override void setColor(Tuple<int, int, int> tuple, Color color)
        {
            string name = "b" + tuple.Item2 + tuple.Item3;
            if (tuple.Item1 == 0)
                ((Button)level4Form1[name]).BackColor = color;
            else if (tuple.Item1 == 1)
                ((Button)level4Form2[name]).BackColor = color;
            else if (tuple.Item1 == 2)
                ((Button)level4Form3[name]).BackColor = color;
            else if (tuple.Item1 == 3)
                ((Button)level4Form4[name]).BackColor = color;
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            setColor(hint.ToTuple(), Color.LightBlue);
            
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
