using System.Collections.Generic;
using System;

namespace Qubic
{
    public interface Cube {
        //cisti kocku
        void clear();
        //vraca vrijednost koja se nalazi na poziciji (i,j,k)
        char value(int i, int j, int k);
        //ako je završno stanje vrača vrijednost, inače null
        Integer result();
        //ova funkcija generira sve moguće poteze na tabli, sprema ih u vektor
        List<Move> generate_moves(); 
        //odigra potez Move sa znakom char
        bool play(Move move,char c);
        //odigra potez unazad
        void unPlay(Move move);
        //heuristicka funkcija
        int heuristic(char player,char opponent);
        //vraca optimalnu dubinu minmax
        int maxDepth();
        //iscrtava kocku u terminalu
        void print();
        //klonira kocku
        Cube clone();
    }
}