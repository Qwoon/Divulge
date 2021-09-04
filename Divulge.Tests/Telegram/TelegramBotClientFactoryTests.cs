using Divulge.Telegram;
using System.Threading.Tasks;
using Xunit;

namespace Divulge.Tests.Telegram
{
    public class TelegramBotClientFactoryTests : BaseTests
    {
        private readonly TelegramBotClientConfig _config;

        public TelegramBotClientFactoryTests()
        {
            _config = new TelegramBotClientConfig()
            {
                AccessToken = "000000000"
            };
        }

        [Fact]
        public async Task ShouldCreateTelegramBotClient()
        {
            var bot = TelegramBotClientFactory.Create(_config);
            Assert.NotNull(bot);
        }
    }
}
