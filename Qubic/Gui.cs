using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qubic
{
    public class Gui : Form
    {
        static public string label = "X";
        static public QubicGame game;
        static public Move hint = null;
        public Tuple<Player, Player> players = Tuple.Create(new Player('X'), new Player('O'));
        public Player player;
        static public int nb_moves = 0;

        public Gui()
        {
            player = players.Item1;
        }
    }
}
