using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Qubic
{
    public class QubicGame
    {
        public Move move;
        //kocka na kojoj se igra
        private Cube mCube;
        private MainForm4x4x4 gui;
        public Thread hintThread;
        //polje od dva igrača
        public Player player;

        public event EventHandler<Player> winner;

        //stvara uvijete za početak igre
        public QubicGame(int gameType, MainForm4x4x4 app)
        {
            //Console.WriteLine("Odaberite verziju igre:");
            //Console.WriteLine("Za igru na kocki 3X3X3 odaberite 3");
            //Console.WriteLine("Za igru na kocki 4X4X4 odaberite 4");
            //Console.WriteLine("Vas odabir: ");

            //int gameType;
            //gameType = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n\n");
            gui = app;
            player = gui.players.Item1;
            if (gameType == 3)
            {
                mCube = new Cube3();
                //Console.WriteLine("----IGRA KRIZIC-KRUZIC U 3D NA 3X3X3 KOCKI ZAPOCINJE----\n");
            }
            else
            {
                mCube = new Cube4();
                //Console.WriteLine("----IGRA KRIZIC-KRUZIC U 3D NA 4X4X4 KOCKI ZAPOCINJE----\n");
            }
        }

        //implementira logiku igre
        public void play()
        {
            Integer result;
            int playerOnMove = 0;

            //mCube.print();
            result = mCube.result();
            while (result == null)
            {
                player = gui.player;
                Hint hint = new Hint(mCube.clone(), player, gui);
                hintThread = new Thread(new ThreadStart(hint.run));
                hintThread.Start();
                while (move == null)
                {
                    try
                    {
                        Thread.Sleep(10);
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        hintThread.Abort();
                        Console.WriteLine("Hint ugasen");
                        return;
                    }
                }
                hintThread.Abort();
                //mPlayers[playerOnMove].play(mCube, move);
                mCube.play(move, player.id());
                move = null;
                mCube.print();
                playerOnMove++;
                result = mCube.result();
            }
            if (result == 500)
                winner(this, gui.players.Item1);

            else if (result == -500)
                winner(this, gui.players.Item1);
        }
    }
}
