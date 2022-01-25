namespace Qubic
{
    public class Hint : Runnable{
    private Cube cube;
    private Player player;

    public event EventHandler<Move> newHint;
    
    Hint(Cube cube, Player player){
        this.cube = cube;
        this.player = player;
    }
    
    public void run () {
        Move hint = player.hint(cube);
        try
        {
            Thread.sleep(10);
            if(newHint != null)
            {
                newHint(this, hint);
            }
        }
        catch(ThreadInterruptedException ex)
        {
            Thread.currentThread().Interrupt();
        }
    }
    
}
}