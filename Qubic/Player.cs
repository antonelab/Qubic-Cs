using System;
using System.Collections.Generic;
using System.Threading;

namespace Qubic
{
    public class Player {
        //oznaka igraca
        private char _id;
        public string name;

        //algoritam min max
        private Pair<Integer, Move> minMax(Cube cube, List<Move> moves, char id, int alpha, int beta, int maxDepth)
        {
            Pair<Integer, Move> result = new Pair<Integer, Move>();
            Integer value;

            //terminal state  
            value = cube.result();
            if(value != null){
                result.first = value;
                return result;
            }

            int n = moves.Count;
            Move move;
            Pair<Integer, Move> temp;

            //maksimana dubina
            if(maxDepth <= 0){
                if(id == 'X') result.first = cube.heuristic('X','O');
                else result.first = cube.heuristic('O','X');
                return result;
            }

            //max
            if(id == 'X'){
                result.first = -1000;
                for(int i=0; i<n; i++){
                    move = moves[0];
                    moves.RemoveAt(0);
                    cube.play(move, 'X');
                    temp = minMax(cube, new List<Move> (moves), 'O', alpha, beta, maxDepth-1);
                    moves.Add(move);
                    cube.unPlay(move);
                    if(temp.first>result.first){
                        result.first=temp.first;
                        result.second = move;
                        alpha = Math.Max(alpha, result.first); 
                    }
                    if (beta <= alpha) break;
                    //kad naidemo na 500 sigurno necemo naci bolje pa izlazimo
                    if(result.first==500)break;
                }
            }

            //min
            else if(id == 'O'){
                result.first=1000;
                for(int i=0; i<n; i++){
                    move = moves[0];
                    moves.RemoveAt(0);
                    cube.play(move, 'O');
                    temp = minMax(cube, new List<Move>(moves), 'X', alpha, beta, maxDepth-1);
                    moves.Add(move);
                    cube.unPlay(move);
                    if(temp.first<result.first){
                        result.first=temp.first;
                        result.second=move;
                        beta = Math.Min(beta, result.first);
                    }
                    if (beta <= alpha) break;
                    //kad naidemo na -500 sigurno necemo naci bolje pa izlazimo
                    if(result.first==-500)break;
                }
            }
            return result;
        }
        
        //Konstruktor
        public Player(char id)
        {
            this._id = id;
        }

        //Funkcija vraca ime igraca
        public char id()
        {
            return _id;
        }
        
        //Funkcija vraća optimalni potez
        public Move hint(Cube cube){
            //Console.WriteLine("Hint za " + id);
            Pair<Integer, Move> result = new Pair<Integer, Move>();
            List<Move> moves = cube.generate_moves();
            Shuffle(moves);

            int alpha = -1000;
            int beta = 1000;
            for(int i = 1; i <= cube.maxDepth(); i++){
                try
                {
                    Thread.Sleep(10);
                    result = minMax(cube, moves, _id, alpha, beta, i);
                    //Console.WriteLine(i + "    " + result.first);
                    if(result.first==-500 || result.first==500)break;
                }
                catch(ThreadInterruptedException ex)
                {
                    Thread.CurrentThread.Interrupt();
                    return null;
                }
            }

            if(_id == 'O' && result.first > 0){
                
                for(int i = 1; i <= cube.maxDepth(); i++){
                    try
                    {
                        Thread.Sleep(10);
                        result = minMax(cube, moves, 'X', alpha, beta, i);
                        if(result.first==-500 || result.first==500)break;
                    }
                    catch(ThreadInterruptedException ex)
                    {
                        Thread.CurrentThread.Interrupt();
                        return null;
                    }  
                }
            }

            else if(_id == 'X' && result.first < 0){
                for(int i = 1; i <= cube.maxDepth(); i++){
                    try
                    {
                        Thread.Sleep(10);
                        result = minMax(cube, moves, 'O', alpha, beta, i);
                        if(result.first==-500 || result.first==500)break;
                    }
                    catch(ThreadInterruptedException ex)
                    {
                        Thread.CurrentThread.Interrupt();
                        return null;
                    }
                }
            }
            
            //Console.WriteLine(result.second);
            return result.second;
        }

        //Funkcija koja stvara slucajan poredak u listi
        private static Random rng = new Random();
        public void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        //Funkcija kojom se izvrsava potez igraca
        /**public void play(Cube cube, Move move)
        {
            
            cube.play(move,mName);
        }**/
    }
}