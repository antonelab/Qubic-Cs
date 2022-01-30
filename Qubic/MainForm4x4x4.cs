using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Qubic
{
    public partial class MainForm4x4x4 : Form
    {
        private database db;
        private String xPlayer, oPlayer;
        int type;
        bool flagSaved = false;

        static public string label = "X";
        static public QubicGame game;
        public Move hint = null;
        public Tuple<Player, Player> players = Tuple.Create(new Player('X'), new Player('O'));
        public Player player;
        public int nb_moves = 0;
        static public Thread gameThread;

        public event EventHandler<Move> newHint;
        public event EventHandler<bool> closed;


        public MainForm4x4x4(string xPlayer, string oPlayer, int type)
        {
            SuspendLayout();
            this.xPlayer = xPlayer;
            this.oPlayer = oPlayer;
            this.type = type;
            InitializeComponent();
            ResumeLayout();
            if(type == 3)
            {
                this.Controls.Remove(this.tableControl);
                this.tableControl = new Qubic.table3Control();
                this.Controls.Add(this.tableControl);
                this.Text = "Qubic - 3x3x3 varijanta";
                this.BackColor = Color.RosyBrown;
                tableControl.BackColor = Color.RosyBrown;
                hintButton.BackColor = Color.DarkSeaGreen;
                xNameLabel.ForeColor = Color.DarkSeaGreen;
            }
            this.ClientSize = new System.Drawing.Size(950, 960);
            this.MinimumSize = new System.Drawing.Size(900, 930);
            db = new database();

            FormClosing += (sender, e) => { gameThread.Interrupt(); gameThread.Join(); };
            tableControl.btnClicked += handleBtnClicked;
            newHint += handleHint;
            xNameLabel.Text = "IME: " + xPlayer;
            oNameLabel.Text = "IME: " + oPlayer;
            hintButton.Enabled = false;

            game = new QubicGame(type, this);
            gameThread = new Thread(new ThreadStart(game.play));
            gameThread.Start();
            player = players.Item1;
            game.winner += handleWinner;

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

        public void handleWinner(object sender, int e)
        {
            lastForm last;
            if (e == 1)  last = new lastForm(xPlayer, e);
            else if (e == 0) last = new lastForm(oPlayer, e);
            else last = new lastForm(oPlayer, e);
            if (this.InvokeRequired)
            {
                Action handle = delegate { handleWinner(sender, e); };
                this.Invoke(handle);
                return;
            }
            /*
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (last.ShowDialog(this) == DialogResult.OK)
            {
                //tu se ugasi igra
                MessageBox.Show("Gasim i spremam");
            }
            else
            {
                //tu se ugasi igra i mozda ne sprema
                MessageBox.Show("Gasim ne spremam");
            }
            last.Dispose();
            */
            last.Show();
            db.insert(xPlayer, oPlayer, "4x4x4", e, nb_moves);
            flagSaved = true;
            last.closedLast += (s, e_bool) =>
            {
                if (e_bool)
                {
                    this.Close();
                }
            };
        }
        public void handleBtnClicked(object sender, Move m)
        {
            char id = player.id();
            if ((id == 'X' && xPlayer.Equals("kompjuter")) || (id == 'O' && oPlayer.Equals("kompjuter")))
                if (hint == null || !m.ToString().Equals( hint.ToString()))
                    return;
            Button button = (Button)sender;
            button.Enabled = false;
            button.Text = "" + id;
            if (hint != null) tableControl.setColor(hint.ToTuple(), default(Color));
            hint = null;
            hintButton.Enabled = false;
            game.move = m;
            nbMoveLabel.Text = (++nb_moves).ToString();
            if (id == 'X')
            {
                player = players.Item2;
                xNameLabel.ForeColor = Color.Black;
                if (type == 4)
                    oNameLabel.ForeColor = Color.RosyBrown;
                else
                    oNameLabel.ForeColor = Color.DarkSeaGreen;
            }
            else
            {
                player = players.Item1;
                oNameLabel.ForeColor = Color.Black;
                if (type == 4)
                    xNameLabel.ForeColor = Color.RosyBrown;
                else
                    xNameLabel.ForeColor = Color.DarkSeaGreen;
            }
        }

        public void Hint(Move m)
        {
            char id = player.id();
            hint = m;
            newHint(this, m);
            if ((id == 'X' && xPlayer.Equals("kompjuter")) || (id == 'O' && oPlayer.Equals("kompjuter")))
            {
                tableControl.clickButton(m.ToTuple());
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
                Action handle = delegate { handleHint(sender, e); };
                hintButton.Invoke(handle);
            }
            else
                hintButton.Enabled = true;
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            tableControl.setColor(hint.ToTuple(), Color.LightBlue);
            
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

        private void MainForm4x4x4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //korisnik gasi
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!flagSaved)
                {
                    if (MessageBox.Show(this,
                             "Jeste li sigurni da želite izaći\n iz igre bez spremanja rezultata?",
                             "Oprez - izlazak",
                             MessageBoxButtons.OKCancel,
                             MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        if (closed != null) closed(this, true);
                    }
                }
                else
                    if (closed != null) closed(this, true);
            }            
        }

        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void predajaXIgračaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.insert(xPlayer, oPlayer, "4x4x4", 0, nb_moves);
            flagSaved = true;
            this.Close();
        }

        private void predajaOIgračaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.insert(xPlayer, oPlayer, "4x4x4", 1, nb_moves);
            flagSaved = true;
            this.Close();
        }

        private void oStatMenu_Click(object sender, EventArgs e)
        {
            var p = new StatForm(oPlayer);
            p.Show();
        }
    }
}
