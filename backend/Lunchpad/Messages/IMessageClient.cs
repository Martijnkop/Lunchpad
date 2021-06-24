using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunchpad.Messages
{
    public interface IMessageClient
    {
        Task Test(string testString);
    }
}
