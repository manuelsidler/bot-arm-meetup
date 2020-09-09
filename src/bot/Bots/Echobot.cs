using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

namespace Echobot.Bots
{
    public class Echobot : IBot
    {
        public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {
            var text = turnContext.Activity.Text;
            await turnContext.SendActivityAsync(MessageFactory.Text($"Echo: {text}"), cancellationToken);
        }
    }
}