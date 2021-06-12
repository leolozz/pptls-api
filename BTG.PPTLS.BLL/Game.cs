using BTG.PPTLS.BLL.Moves;
using BTG.PPTLS.Domain.Enum;
using BTG.PPTLS.Domain.Models;
using System;
using System.Collections.Generic;

namespace BTG.PPTLS.BLL
{
    public class Game : IGame
    {
        public Dictionary<GameMoves, MoveBase> MoveDictionary { get; set; }
        public Player ResultPlayer { get; set; }

        public Game()
        {
            MoveDictionary = new Dictionary<GameMoves, MoveBase>
            {
                {GameMoves.Rock, new RockMove() },
                {GameMoves.Paper, new PaperMove() },
                {GameMoves.Scissors, new ScissorsMove() },
                {GameMoves.Lizard, new LizardMove() },
                {GameMoves.Spock, new SpockMove() }
            };

        }

        public Player PlayGame(Player playerOne, Player playerTwo)
        {

            if (GetMove(playerOne.MoveId).ItsADraw(playerTwo.MoveId))
            {
                ResultPlayer = new Player()
                {
                    Id = 0,
                    MoveId = playerOne.MoveId
                };
            }
            else
            {
                if (GetMove(playerOne.MoveId).DoIWin(playerTwo.MoveId))
                {
                    ResultPlayer = playerOne;
                }
                else
                {
                    ResultPlayer = playerTwo;
                }
            }


            return ResultPlayer;
        }

        private MoveBase GetMove(GameMoves moveId)
        {
            return MoveDictionary[moveId];
        }
    }
}
