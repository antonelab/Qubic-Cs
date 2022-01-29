using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Qubic
{
    public class Gui : Form
    {
        static public string label = "X";
        static public QubicGame game;
        public Move hint = null;
        public Tuple<Player, Player> players = Tuple.Create(new Player('X'), new Player('O'));
        public Player player;
        static public int nb_moves = 0;
        static public Thread gameThread;

        public event EventHandler<Move> btnClicked;
        public event EventHandler<Move> newHint;

        public Gui() { }
        public Gui(int type)
        {
            game = new QubicGame(type, this);
            gameThread = new Thread(new ThreadStart(game.play));
            gameThread.Start();
            player = players.Item1;
            this.btnClicked += handleBtnClicked;
            game.winner += (sender, e) => MessageBox.Show(e.id().ToString());
        }

        ~Gui()
        {
            gameThread.Interrupt();
            gameThread.Join();
        }

        public void raiseBtnClicked(object s, Tuple<int,int> e, int i)
        {
            if(btnClicked != null)
                   btnClicked(s, new Move(i, e.Item1, e.Item2));
        }


        public void handleBtnClicked(object sender, Move m)
        {
            Button button = (Button)sender;
            button.Enabled = false;
            char id = player.id();
            button.Text = "" + id;
            if(hint != null) setColor(hint.ToTuple(), SystemColors.Control);
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

        public virtual void setColor(Tuple<int, int, int> tuple, Color color) { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Gui
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Gui";
            this.ResumeLayout(false);

        }
    }
}
