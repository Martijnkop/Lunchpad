using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunchpad.Messages
{
    public class MessageHub : Hub<IMessageClient>
    {
        public async Task GetTestMessage()
        {
            await Clients.Caller.Test("HEllo world!");
        }
    }
}
