using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeBlip.chatbot.API.Entities;

namespace TakeBlip.chatbot.API.Repositories
{
    public interface ITakeBlipRepository : IDisposable
    {
        Task<List<Root>> GetRepositoriesAsync();        
    }
}
