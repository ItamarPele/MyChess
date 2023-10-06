using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyChess
{
    public abstract class Piece
    {
        protected Color color;
        protected Position pos;
        protected static Board board = new Board();

        public Piece(Color c, Position pos)
        {
            this.color = c;
            this.pos = pos;
        }

        public void InsertMovesToList()
        {
            MyColorMoves.AddMovesToList(color, GetPossibleMoves());
        }
        public Color GetColor()
        {
            return this.color;
        }
        public abstract List<Move> GetPossibleMoves();



    }
}
