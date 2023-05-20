using Core.Loyal.Models.FTMUSIC;
using CORE.Loyal.Interfaces.Services;
using CORE.Loyal.Models.FTMUSIC;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Support.Loyal.DTOs;
using Support.Loyal.Util;
using System.Timers;

namespace API.Loyal.Controllers
{

    
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController:ControllerBase
    {

        private readonly INotificationServices _provider;

        public NotificationController(INotificationServices provider)
        {
            _provider = provider;
        }

    }
}
