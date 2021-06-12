using System;
using System.Collections.Generic;
using System.Text;
using BTG.PPTLS.Domain.Enum;

namespace BTG.PPTLS.BLL.Moves
{
    class RockMove : MoveBase
    {
        public override ICollection<GameMoves> WinsOver
        {
            get
            {
                return new List<GameMoves>
                {
                   GameMoves.Scissors,
                   GameMoves.Lizard

                };
            }
        }
        public override GameMoves DrawsWith
        {
            get
            {
                return GameMoves.Rock;
            }
        }
    }
}
