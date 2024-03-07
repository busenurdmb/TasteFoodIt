using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIt.Entity
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string IsRead { get; set; }
        public string NotificationIcon { get; set; }
        public string IconCirleColor { get; set; }
    }
}