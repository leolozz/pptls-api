using System;
using System.Collections.Generic;
using System.Text;
using BTG.PPTLS.Domain.Enum;

namespace BTG.PPTLS.BLL.Moves
{
    class SpockMove : MoveBase
    {
        public override ICollection<GameMoves> WinsOver
        {
            get
            {
                return new List<GameMoves>
                {
                   GameMoves.Scissors,
                   GameMoves.Rock

                };
            }
        }
        public override GameMoves DrawsWith
        {
            get
            {
                return GameMoves.Spock;
            }
        }
    }
}
