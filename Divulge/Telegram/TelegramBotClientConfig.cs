using System.Net.Http;

namespace Divulge.Telegram
{
    public class TelegramBotClientConfig
    {
        public string AccessToken { get; set; }
        public HttpClient HttpClient { get; set; } = null;
        public string BaseUrl { get; set; } = null;
    }
}
