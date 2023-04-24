﻿using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Models;
using System.Collections.Generic;

namespace Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessageModelsController : ControllerBase
    {
        IMessageLogic logic;
        IHubContext<SignalRHub> hub;

        public MessageModelsController(IMessageLogic logic, IHubContext<SignalRHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }

        [HttpPost]
        public void Create([FromBody] MessageModels value)
        {
            this.logic.Add(value);
            this.hub.Clients.All.SendAsync("MessageCreated", value);
        }

        [HttpGet]
        public IEnumerable<MessageModels> ReadAll()
        {
            return this.logic.ReadAll();
        }

    }
}