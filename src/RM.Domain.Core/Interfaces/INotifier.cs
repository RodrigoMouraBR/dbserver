using RM.Domain.Core.Notifications;
using System.Collections.Generic;

namespace RM.Domain.Core.Interfaces
{
    public interface INotifier
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
