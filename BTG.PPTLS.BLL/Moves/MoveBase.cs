using BTG.PPTLS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTG.PPTLS.BLL.Moves
{
    public abstract class MoveBase
    {
        public abstract ICollection<GameMoves> WinsOver { get; }
        public abstract GameMoves DrawsWith { get;  }
        public bool ItsADraw(GameMoves moveId) => DrawsWith.Equals(moveId);
        public bool DoIWin(GameMoves moveId) => WinsOver.Contains(moveId);
    }
}
