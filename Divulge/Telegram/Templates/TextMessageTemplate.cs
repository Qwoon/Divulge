using Divulge.Telegram.Models;

namespace Divulge.Telegram.Templates
{
    public class TextMessageTemplate : BaseMessageTemplate
    {
        protected override BaseMessageModel MessageModel { get; set; }

        public TextMessageTemplate(TextMessageModel textMessage)
        {
            MessageModel = textMessage;
        }

        public string CreateMessageText()
        {
            var textMessage = (TextMessageModel)MessageModel;

            if (textMessage.IncludeEmojis)
            {
                textMessage.Text = textMessage.Text.ConvertEmojis();
            }

            return textMessage.Text.ConvertNewLines();
        }
    }
}
