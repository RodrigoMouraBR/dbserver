using RM.Domain.Core.Interfaces;

namespace RM.Domain.Core.Notifications
{
    public class Notification
    {
        public Notification(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
