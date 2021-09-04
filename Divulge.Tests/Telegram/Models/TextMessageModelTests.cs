using Divulge.Telegram.Models;
using Telegram.Bot.Types.Enums;
using Xunit;

namespace Divulge.Tests.Telegram.Models
{
    public class TextMessageModelTests : BaseTests
    {
        [Fact]
        public void TextMessageModelTest()
        {
            var chatId = 1;
            var disableNotification = true;
            var includeEmojis = true;
            var parseMode = ParseMode.Markdown;
            var text = ":upside_down_face: Hello, World!\n*I am writing to you in bold!* :kissing:";

            var textMessageModel = new TextMessageModel
            {
                ChatId = chatId,
                DisableNotification = disableNotification,
                IncludeEmojis = includeEmojis,
                ParseMode = parseMode,
                Text = text
            };

            Assert.NotNull(textMessageModel);
            Assert.Equal(chatId, textMessageModel.ChatId);
            Assert.Equal(disableNotification, textMessageModel.DisableNotification);
            Assert.Equal(includeEmojis, textMessageModel.IncludeEmojis);
            Assert.Equal(parseMode, textMessageModel.ParseMode);
            Assert.Equal(text, textMessageModel.Text);
            Assert.Equal(System.DateTime.Now.ToLongDateString(), textMessageModel.Date);
            Assert.Equal(System.DateTime.Now.ToLongTimeString(), textMessageModel.Time);
        }
    }
}
