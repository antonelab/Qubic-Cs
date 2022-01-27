using System.Threading;
using System;

namespace Qubic
{
    public class Hint{
        private Cube cube;
        private Player player;
        private Object gui;

        public event EventHandler<Move> newHint;
    
        public Hint(Cube cube, Player player, Gui gui){
            this.cube = cube;
            this.player = player;
            this.gui = gui;
        }
    
        public void run () {
            Move hint = player.hint(cube);
            try
            {
                Thread.Sleep(10);
                if(newHint != null)
                {
                    newHint(this, hint);
                }
            }
            catch(ThreadInterruptedException ex)
            {
                Thread.CurrentThread.Interrupt();
            }
        }
    
    }
}