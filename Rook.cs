using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChess
{
    public class Rook : Piece
    {
        public Rook(Color c, Position pos) : base(c, pos) { }

 
        public override List<Move> GetPossibleMoves()
        {
            List <Move> l = new List<Move>();
            Piece[,] b = board.ReadBoard();
            //up down
            for(short i = 0; i<Board.LEN; i++ )
            {
                if (i == pos.x)//if this is my position
                    continue;
                l.Add(new Move(this.pos, new Position(this.pos.x, i)));

                if (b[this.pos.x, i] != null)//if another pieace is in the position
                {
                    if (b[this.pos.x, i].GetColor() == this.color)
                        //if it is not same color piece can still land there, if it is same color this can't happen
                        l.RemoveAt(l.Count - 1); // remove last move
                    break;
                }
            }
            //left right
            for (short i = 0; i < Board.LEN; i++)
            {
                if (i == pos.y)
                    continue;
                l.Add(new Move(this.pos, new Position(i, this.pos.y)));

                if (b[i, this.pos.y] != null)
                {
                    if (b[i, this.pos.y].GetColor() == this.color)
                        l.RemoveAt(l.Count - 1); 
                    break;
                }
            }
            return l;
        }

    }
}
