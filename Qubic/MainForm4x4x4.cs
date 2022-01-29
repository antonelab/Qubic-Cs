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

        static public string label = "X";
        static public QubicGame game;
        public Move hint = null;
        public Tuple<Player, Player> players = Tuple.Create(new Player('X'), new Player('O'));
        public Player player;
        static public int nb_moves = 0;
        static public Thread gameThread;

        public event EventHandler<Move> newHint;


        public MainForm4x4x4(string xPlayer, string oPlayer, int type)
        {
            SuspendLayout();
            this.xPlayer = xPlayer;
            this.oPlayer = oPlayer;
            this.type = type;
            InitializeComponent();
            db = new database();

            FormClosing += (sender, e) => { gameThread.Interrupt(); gameThread.Join(); };
            table41.btnClicked += handleBtnClicked;
            /*level4Form1.btnClicked += (sender, e) => { hintButton.Enabled = false; raiseBtnClicked(sender, e, 0); };
            level4Form2.btnClicked += (sender, e) => raiseBtnClicked(sender, e, 1);
            level4Form3.btnClicked += (sender, e) => raiseBtnClicked(sender, e, 2);
            level4Form4.btnClicked += (sender, e) => raiseBtnClicked(sender, e, 3);*/
            newHint += handleHint;
            xNameLabel.Text = "IME: " + xPlayer;
            oNameLabel.Text = "IME: " + oPlayer;
            hintButton.Enabled = false;

            game = new QubicGame(type, this);
            gameThread = new Thread(new ThreadStart(game.play));
            gameThread.Start();
            player = players.Item1;
            game.winner += (sender, e) => MessageBox.Show(e.id().ToString());

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
            ResumeLayout();
        }

        public void raiseBtnClicked(object s, Tuple<int, int> e, int i)
        {
            /*if (btnClicked != null)
                btnClicked(s, new Move(i, e.Item1, e.Item2));*/
        }


        public void handleBtnClicked(object sender, Move m)
        {
            char id = player.id();
            Button button = (Button)sender;
            button.Enabled = false;
            button.Text = "" + id;
            if (hint != null) table41.setColor(hint.ToTuple(), SystemColors.Control);
            hint = null;
            game.move = m;
            nb_moves++;
            if (id == 'X')
                player = players.Item2;
            else
                player = players.Item1;
        }

        public void Hint(Move m)
        {
            hint = m;
            newHint(this, m);
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

        private void hintButton_Click(object sender, EventArgs e)
        {
            table41.setColor(hint.ToTuple(), Color.LightBlue);
            
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
