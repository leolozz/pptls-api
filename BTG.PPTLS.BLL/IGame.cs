using BTG.PPTLS.Domain.Models;

namespace BTG.PPTLS.BLL
{
    public interface IGame
    {
        Player PlayGame(Player playerOne, Player playerTwo);
    }
}