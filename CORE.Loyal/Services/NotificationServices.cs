using CORE.Loyal.Interfaces.Providers;
using Support.Loyal.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORE.Loyal.Interfaces.Services;
using CORE.Loyal.Models.FTMUSIC;

namespace CORE.Loyal.Services
{
    public class NotificationServices: INotificationServices
    {
        private readonly INotificationProvider _provider;
        public NotificationServices(INotificationProvider provider)
        {
            _provider = provider;
        }
        
    }
}
