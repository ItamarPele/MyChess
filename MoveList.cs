using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChess
{
    //this is the class that contains valid (but necceraly leagal!!!) moves for white and black.

    //valid moves are moves that do not jump over pieces or step out of bounds.
    //all moves merged into have already passed a validity check.

    //leagal moves are moves that do not endagere the king.
    //validity test for leagal moves will be implemnted in a later stage.

    //there are 2 instences to this class: White and Black

    public class MoveList
    {
        private List<Move> mList;
        private static short instanceCount = 0;
        private const short maxInstances = 2;

        public MoveList()
        {
            if (instanceCount >= maxInstances)
                throw new Exception("Only 2 instances of MoveList can be created.");
            this.mList = new List<Move>();
            instanceCount++;
        }
        public void MergeMovesList(List<Move> otherPList)
        {
            this.mList.AddRange(otherPList);
        }
        public void Clean()
        {
            this.mList.Clear();
        }
        public bool IsMoveValid(Move move)
        {
            return this.mList.Contains(move);//TODO: add no king sack validity
        }
    }
}
