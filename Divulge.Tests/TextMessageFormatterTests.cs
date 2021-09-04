using System;
using Xunit;

namespace Divulge.Tests
{
    public class TextMessageFormatterTests : BaseTests
    {
        [Fact]
        public void ConvertNewLinesTest()
        {
            var text = "\n Hello, World \n\n We are happy to see you";

            var formattedText = TextMessageFormatter.ConvertNewLines(text);

            Assert.NotNull(formattedText);
            Assert.True(formattedText.IndexOf(Environment.NewLine) == 0);
            Assert.True(formattedText.IndexOf($"{Environment.NewLine}{Environment.NewLine}") == 16);
        }

        [Fact] 
        public void ConvertEmojisTest()
        {
            var textWithEmbeddedEmoji = "Hello, World! :upside_down_face:";
            var expectedResult = "Hello, World! 🙃";

            var actualResult = TextMessageFormatter.ConvertEmojis(textWithEmbeddedEmoji);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
