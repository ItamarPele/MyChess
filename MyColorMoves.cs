using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChess
{
    public static class MyColorMoves
    {
        private static MoveList Black = new MoveList();
        private static MoveList White = new MoveList();

        public static void AddMovesToList(Color c, List<Move> moves)
        {
            if (c == Color.Black)
                Black.MergeMovesList(moves);
            else if (c == Color.White)
                White.MergeMovesList(moves);
            else
                throw new Exception("color should be either black or white");
        }



    }
}
