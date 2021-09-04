using Divulge.Telegram.Models;
using Divulge.Telegram.Templates;
using System;
using Telegram.Bot.Types.Enums;
using Xunit;

namespace Divulge.Tests.Telegram.Templates
{
    public class TextMessageTemplateTests : BaseTests
    {
        [Fact]
        public void TextMessageTemplateConstructorTest()
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

            var textMessageTemplate = new TextMessageTemplate(textMessageModel);

            Assert.NotNull(textMessageTemplate);
        }

        [Fact]
        public void CreateMessageTextWithoutEmojiAndDefaultParseModeTest()
        {
            var chatId = 1;
            var disableNotification = true;
            var includeEmojis = false;
            var parseMode = ParseMode.Default;
            var text = "Hello, World!\n*I am writing to you in bold!*";

            var textMessageModel = new TextMessageModel
            {
                ChatId = chatId,
                DisableNotification = disableNotification,
                IncludeEmojis = includeEmojis,
                ParseMode = parseMode,
                Text = text
            };

            var textMessageTemplate = new TextMessageTemplate(textMessageModel);
            var expectedResult = $"Hello, World!{Environment.NewLine}*I am writing to you in bold!*";
            var textMessage = textMessageTemplate.CreateMessageText();

            Assert.Equal(expectedResult, textMessage);
        }


        [Fact]
        public void CreateMessageTextWithEmojiAndMarkdownParseModeTest()
        {
            var chatId = 1;
            var disableNotification = true;
            var includeEmojis = true;
            var parseMode = ParseMode.Default;
            var text = ":upside_down_face: Hello, World!\n*I am writing to you in bold!* :kissing:";

            var textMessageModel = new TextMessageModel
            {
                ChatId = chatId,
                DisableNotification = disableNotification,
                IncludeEmojis = includeEmojis,
                ParseMode = parseMode,
                Text = text
            };

            var textMessageTemplate = new TextMessageTemplate(textMessageModel);
            var expectedResult = $"🙃 Hello, World!{Environment.NewLine}*I am writing to you in bold!* 😗";
            var textMessage = textMessageTemplate.CreateMessageText();

            Assert.Equal(expectedResult, textMessage);
        }

        public void CreateMessageTextWithEmojiAndDefaultParseModeTest()
        {
            var chatId = 1;
            var disableNotification = true;
            var includeEmojis = true;
            var parseMode = ParseMode.Default;
            var text = ":upside_down_face: Hello, World!\n*I am writing to you in bold!* :kissing:";

            var textMessageModel = new TextMessageModel
            {
                ChatId = chatId,
                DisableNotification = disableNotification,
                IncludeEmojis = includeEmojis,
                ParseMode = parseMode,
                Text = text
            };

            var textMessageTemplate = new TextMessageTemplate(textMessageModel);
            var expectedResult = $":upside_down_face: Hello, World!{Environment.NewLine}*I am writing to you in bold!* :kissing:";
            var textMessage = textMessageTemplate.CreateMessageText();

            Assert.Equal(expectedResult, textMessage);
        }
    }
}
