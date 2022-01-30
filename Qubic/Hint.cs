using System.Threading;
using System;

namespace Qubic
{
    public class Hint{
        private Cube cube;
        private Player player;
        private QubicMainForm gui;
    
        public Hint(Cube cube, Player player, QubicMainForm gui){
            this.cube = cube;
            this.player = player;
            this.gui = gui;
        }
    
        public void run () {
            Move hint = player.hint(cube);
            try
            {
                Thread.Sleep(10);
                //Console.WriteLine("Hint: " + hint);
                gui.Hint(hint);
            }
            catch(ThreadInterruptedException ex)
            {
                
            }
        }
    
    }
}