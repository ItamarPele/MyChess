using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyChess
{
    public class Bishop : Piece
    {
        public Bishop(Color c, Position pos) : base(c, pos) { }

        public void bishopMoves(List<Move> l, Piece[,] b, short xUpOrDown, short yUpOrDown)
        {
            short i = 1;
            Position possibaleP = new Position((short)(this.pos.x + i* xUpOrDown), (short)(this.pos.y + i* yUpOrDown));
            while (IsPosInRange(possibaleP))
            {
                l.Add(new Move(this.pos, possibaleP));

                if (b[possibaleP.x, possibaleP.y] != null)//if another pieace is in the position
                {
                    if (b[possibaleP.x, possibaleP.y].GetColor() == this.color)
                        l.RemoveAt(l.Count - 1);
                    break;
                }
                i++;
                possibaleP = new Position((short)(this.pos.x + i* xUpOrDown), (short)(this.pos.y + i* yUpOrDown));
            }
        }

        public override List<Move> GetPossibleMoves()
        {
            List<Move> l = new List<Move>();
            Piece[,] b = board.ReadBoard();
            void BshortCut(short xUpOrDown, short yUpOrDown)
            {
                bishopMoves(l, b, xUpOrDown, yUpOrDown);
            }
            BshortCut(1, 1);
            BshortCut(1, -1);
            BshortCut(-1, 1);
            BshortCut(-1, -1);

            return l;
        }
    }
}
