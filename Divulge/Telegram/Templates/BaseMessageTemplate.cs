using Divulge.Telegram.Models;

namespace Divulge.Telegram.Templates
{
    public abstract class BaseMessageTemplate
    {
        protected abstract BaseMessageModel MessageModel { get; set; }
    }
}
