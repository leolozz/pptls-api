using System;
using System.Collections.Generic;
using System.Text;
using BTG.PPTLS.Domain.Enum;

namespace BTG.PPTLS.BLL.Moves
{
    class LizardMove : MoveBase
    {
        public override ICollection<GameMoves> WinsOver
        {
            get
            {
                return new List<GameMoves>
                {
                   GameMoves.Paper,
                   GameMoves.Spock

                };
            }
        }
        public override GameMoves DrawsWith
        {
            get
            {
                return GameMoves.Lizard;
            }
        }
    }
}
