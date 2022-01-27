using System;

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
    
    public Move(string line){
        string[] elements = line.Split(',');
        mLevel = int.Parse(elements[0]);
        mRow = int.Parse(elements[1]);
        mColumn = int.Parse(elements[2]);
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
    public override string ToString()
    {
        return mLevel + "," + mRow + "," + mColumn;
    }
    
    public override bool Equals(Object o) {
        // Provjerava usporedujemo li objekt sa samim sobom
        if (o == this) {
            return true;
        }
  
        //Provjera je li o tipa Move
        if (!(o is Move)) {
            return false;
        }
          
        // Pretvara o u Move da ih mozemo usporediti 
        Move m = (Move) o;
        return this.ToString().Equals(m.ToString());
    }
}
}