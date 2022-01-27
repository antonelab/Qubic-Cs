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
        private Gui gui;
        public Thread hintThread;
        //polje od dva igrača
        public Player player;

        //stvara uvijete za početak igre
        public QubicGame(int gameType, Gui app)
        {
            //System.out.println("Odaberite verziju igre:");
            //System.out.println("Za igru na kocki 3X3X3 odaberite 3");
            //System.out.println("Za igru na kocki 4X4X4 odaberite 4");
            //System.out.println("Vas odabir: ");

            //int gameType;
            //Scanner myInput = new Scanner( System.in );
            //gameType = myInput.nextInt();
            //System.out.println("\n\n");
            gui = app;
            player = gui.players.Item1;
            if (gameType == 3)
            {
                mCube = new Cube3();
                //System.out.println("----IGRA KRIZIC-KRUZIC U 3D NA 3X3X3 KOCKI ZAPOCINJE----\n");
            }
            else
            {
                mCube = new Cube4();
                //System.out.println("----IGRA KRIZIC-KRUZIC U 3D NA 4X4X4 KOCKI ZAPOCINJE----\n");
            }
        }

        //implementira logiku igre
        public Player play()
        {
            Player winner = null;
            int result;
            int playerOnMove = 0;

            //mCube.print();
            result = mCube.result();
            while (result == null)
            {
                Hint hint = new Hint(mCube.clone(), gui.player, gui);
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
                        Thread.CurrentThread.Interrupt();
                    }
                }
                //mPlayers[playerOnMove].play(mCube, move);
                mCube.play(move, player.id());
                move = null;
                mCube.print();
                playerOnMove++;
                result = mCube.result();
            }
            if (result == 500)
                winner = gui.players.Item1;

            else if (result == -500)
                winner = gui.players.Item2;
            return winner;
        }
    }
}
