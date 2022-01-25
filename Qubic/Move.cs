namespace Qubic
{
    public class Move {
    private int mLevel;
    private int mRow;
    private int mColumn;

    //KONSTRUKTORI
    public Move(){
        mLevel = 0;
        mRow = 0;
        mColumn = 0;
    }
    
    public Move(String line){
        String[] elements = line.split(",");
        mLevel = Integer.parseInt(elements[0]);
        mRow = Integer.parseInt(elements[1]);
        mColumn = Integer.parseInt(elements[2]);
    }
    
    public Move(int i, int j, int k){
        mLevel = i;
        mRow = j;
        mColumn = k;
    }
    //vracaju pripadnu varijablu clanicu
    public int level(){return mLevel;}
    public int row(){return mRow;}
    public int column(){return mColumn;}
    
    //pretvara Move u String
    //sluzi za ispis
    public String ToString()
    {
        return mLevel + "," + mRow + "," + mColumn;
    }
    
    public boolean Equals(Object o) {
        // Provjerava usporedujemo li objekt sa samim sobom
        if (o == this) {
            return true;
        }
  
        //Provjera je li o tipa Move
        if (o is not Move) {
            return false;
        }
          
        // Pretvara o u Move da ih mozemo usporediti 
        Move m = (Move) o;
        return this.ToString().Equals(m.ToString());
    }
}
}