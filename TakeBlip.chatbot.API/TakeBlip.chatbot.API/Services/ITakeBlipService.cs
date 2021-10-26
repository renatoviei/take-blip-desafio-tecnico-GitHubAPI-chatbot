using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeBlip.chatbot.API.Entities;
using TakeBlip.chatbot.API.ViewModel;

namespace TakeBlip.chatbot.API.Services
{
    public interface ITakeBlipService : IDisposable
    {
        Task<List<RootViewModel>> GetRepositoriesAsync();
    }
}
