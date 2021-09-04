using System;

namespace Divulge.Telegram.Models
{
    public class BaseMessageModel
    {
        public long ChatId { get; set; }
        public bool DisableNotification { get; set; }
        public string Date => DateTime.Now.ToLongDateString();
        public string Time => DateTime.Now.ToLongTimeString();
    }
}
