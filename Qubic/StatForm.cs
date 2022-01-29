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
    public partial class StatForm : Form
    {
        private database db;
        public StatForm(string player)
        {
            InitializeComponent();
            db = new database();

            xWins4.Text = db.playerResultCount(player, "X", 1, "4x4x4");
            xWins3.Text = db.playerResultCount(player, "X", 1, "3x3x3");
            xDraw3.Text = db.playerResultCount(player, "X", -1, "3x3x3");
            xDraw4.Text = db.playerResultCount(player, "X", -1, "4x4x4");

            oWins4.Text = db.playerResultCount(player, "O", 1, "4x4x4");
            oWins3.Text = db.playerResultCount(player, "O", 1, "3x3x3");
            oDraw3.Text = db.playerResultCount(player, "O", -1, "3x3x3");
            oDraw4.Text = db.playerResultCount(player, "O", -1, "4x4x4");

            total4.Text = db.totalGames(player, "4x4x4");
            total3.Text = db.totalGames(player, "3x3x3");

            avg3.Text = db.movesAvg(player, "3x3x3");
            avg4.Text = db.movesAvg(player, "4x4x4");

            last4.Text = db.lastPlayed(player, "4x4x4");
            last3.Text = db.lastPlayed(player, "3x3x3");
        }
    }
}
