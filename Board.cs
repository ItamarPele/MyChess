using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChess
{
    public class Board
    {
        public const short LEN = 8;
        private Piece[,] board;
        
        public Board()
        {
            this.board = new Piece[LEN, LEN];
        }

        private Piece[,] DeepCopyBoard()
        {
            Piece[,] newB = new Piece[LEN, LEN];

            for(short i =0; i < LEN; i++)
            {
                for (short j = 0; j < LEN; j++)
                {
                    newB[i, j] = this.board[i, j];
                    
                }
            }
            return newB;
        }
        public Piece[,] ReadBoard()
        {
            return DeepCopyBoard();
        }
        public void MovePiece(Move m)
        {
            this.board[m.newPos.x, m.newPos.y] = this.board[m.myPos.x, m.myPos.y];
        }
         
        //Only for debug
        public void InsertPeice(Piece p, Position pos)
        {
            this.board[pos.x, pos.y] = p;
        }

    }
}
