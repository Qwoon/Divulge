using Telegram.Bot.Types.Enums;

namespace Divulge.Telegram.Models
{
    public class TextMessageModel : BaseMessageModel
    {
        public string Text { get; set; }
        public bool IncludeEmojis { get; set; }
        public ParseMode ParseMode { get; set; }
    }
}
