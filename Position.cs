using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChess
{
    public class Position
    {
        public short x;
        public short y;

        public Position(short x, short y)
        {
            this.x = x;
            this.y = y;
        }
        public Position(Position other)
        {
            this.x = other.x;
            this.y = other.y;
        }

    }
}
