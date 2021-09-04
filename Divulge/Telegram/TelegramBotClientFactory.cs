using Telegram.Bot;

namespace Divulge.Telegram
{
    public class TelegramBotClientFactory
    {
        public static TelegramBotClient Create(TelegramBotClientConfig config)
        {
            return new TelegramBotClient(config.AccessToken, config.HttpClient, config.BaseUrl);
        }
    }
}
