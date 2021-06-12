using BTG.PPTLS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTG.PPTLS.Domain.Models
{
    public class Player
    {
        public int Id { get; set; }
        public GameMoves MoveId { get; set; }
    }
}
