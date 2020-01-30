using RM.Domain.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RM.Domain.Core.Notifications
{
    public class Notifier : INotifier
    {

        private List<Notification> _notification;

        public Notifier(List<Notification> notification)
        {
            _notification = notification;
        }

        public List<Notification> GetNotifications()
        {
            return _notification;
        }

        public void Handle(Notification notification)
        {
            _notification.Add(notification);
        }

        public bool HasNotification()
        {
            return _notification.Any();
        }
    }
}
