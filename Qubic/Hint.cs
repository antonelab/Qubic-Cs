using System.Threading;
using System;

namespace Qubic
{
    public class Hint{
        private Cube cube;
        private Player player;
        private MainForm4x4x4 gui;
    
        public Hint(Cube cube, Player player, MainForm4x4x4 gui){
            this.cube = cube;
            this.player = player;
            this.gui = gui;
        }
    
        public void run () {
            Move hint = player.hint(cube);
            try
            {
                Thread.Sleep(10);
                Console.WriteLine("Hint: " + hint);
                gui.Hint(hint);
            }
            catch(ThreadInterruptedException ex)
            {
                
            }
        }
    
    }
}