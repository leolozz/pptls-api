using BTG.PPTLS.BLL;
using BTG.PPTLS.Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTG.PPTLS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        public GameController(IGame game)
        {
            _game = game;
        }

        private readonly IGame _game;   

        [HttpPost]
        [Route("PlayGame")]
        public IActionResult PlayGame(List<Player> players)
        {

            IActionResult result;

            try
            {
                result = new OkObjectResult(_game.PlayGame(players[0], players[1]));
            }
            catch (Exception ex)
            {
                result = new BadRequestResult();
            }

            return result;
        }
    }
}
