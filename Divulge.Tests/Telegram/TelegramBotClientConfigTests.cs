using Divulge.Telegram;
using System.Net.Http;
using Xunit;

namespace Divulge.Tests.Telegram
{
    public class TelegramBotClientConfigTests : BaseTests
    {
        [Fact]
        public void ConfigTests()
        {
            var accessToken = "000000000";
            HttpClient httpClient = null;
            string baseUrl = "https://google.com";

            var telegramBotClientConfig = new TelegramBotClientConfig
            {
                AccessToken = accessToken,
                HttpClient = httpClient,
                BaseUrl = baseUrl
            };

            Assert.Equal(accessToken, telegramBotClientConfig.AccessToken);
            Assert.Equal(httpClient, telegramBotClientConfig.HttpClient);
            Assert.Equal(baseUrl, telegramBotClientConfig.BaseUrl);
        }
    }
}
