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

        public void InsertMovesToList()
        {

        }
        public abstract List<Move> GetPossibleMoves();



    }
}
