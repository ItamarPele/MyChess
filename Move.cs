using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChess
{
    
    public class Move
    {
        public Position myPos;
        public Position newPos; 

        public Move(Position myPos, Position newPos)
        {
            this.myPos = new Position(myPos);
            this.newPos = new Position(newPos);

        }


        public Move(short myPosX, short myPosY, short newPosX, short newPosY)
        {
            this.myPos = new Position(myPosX, myPosY);
            this.newPos = new Position(newPosX, newPosY);
        }
        public Move(char myPosX, short myPosY, char newPosX, short newPosY) : //change char to short
            this(
                (short)((int)myPosX - (int)'a' + 1),
                myPosY,
                (short)((int)newPosX - (int)'a' + 1),
                newPosY
                )
        {}
        public Move(string myPosX, string myPosY, string newPosX, string newPosY) : //all string, asuming X are chars and Y are numbers
            this(
                (char)myPosX[0],
                (short)(int.Parse(myPosY)),
                (char)newPosX[0],
                (short)(int.Parse(newPosY))
                )
        { }




    }
}
