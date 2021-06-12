using System;
using System.Collections.Generic;
using System.Text;
using BTG.PPTLS.Domain.Enum;

namespace BTG.PPTLS.BLL.Moves
{
    class PaperMove : MoveBase
    {
        public override ICollection<GameMoves> WinsOver
        {
            get
            {
                return new List<GameMoves>
                {
                   GameMoves.Rock,
                   GameMoves.Spock

                };
            }
        }
        public override GameMoves DrawsWith
        {
            get
            {
                return GameMoves.Paper;
            }
        }
    }
}
