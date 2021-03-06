using System.Threading.Tasks;
using DevQuiz.TelegramBot.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Telegram.Bot.Types;

namespace DevQuiz.TelegramBot.Controllers
{
    /// <summary>
    ///     Update controller
    /// </summary>
    [Route("api/[controller]")]
    public class UpdateController : Controller
    {
        private readonly IBotMessageService _botMessageService;
        private readonly ILogger<UpdateController> _logger;

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="botMessageService">Service for manage bot messages</param>
        /// <param name="logger">Logger instance</param>
        public UpdateController(IBotMessageService botMessageService, ILogger<UpdateController> logger = null)
        {
            _botMessageService = botMessageService;
            _logger = logger ?? NullLogger<UpdateController>.Instance;
        }

        /// <summary>
        ///     Post method for receive messages from Bot (Using webhook)
        /// </summary>
        /// <param name="update">New Update from bot</param>
        /// <returns>Ok Action or error</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            await _botMessageService.ProcessUpdateAsync(update);
            return Ok();
        }
    }
}