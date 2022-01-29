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


        public void handleBtnClicked(object sender, Move m)
        {
            char id = player.id();
            if ((id == 'X' && xPlayer.Equals("kompjuter")) || (id == 'O' && oPlayer.Equals("kompjuter")))
                if (hint == null || !m.ToString().Equals( hint.ToString()))
                    return;
            Button button = (Button)sender;
            button.Enabled = false;
            button.Text = "" + id;
            if (hint != null) table41.setColor(hint.ToTuple(), default(Color));
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
                table41.clickButton(m.ToTuple());
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
