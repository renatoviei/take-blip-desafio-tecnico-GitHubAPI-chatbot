using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeBlip.chatbot.API.Repositories;
using TakeBlip.chatbot.API.Services;
using TakeBlip.chatbot.API.ViewModel;

namespace TakeBlip.chatbot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TakeBlipController : ControllerBase
    {
        private readonly ITakeBlipService _tbService;

        public TakeBlipController(ITakeBlipService tbService)
        {
            _tbService = tbService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RootViewModel>>> GetRepositoriesAsync()
        {
            var repositories = await _tbService.GetRepositoriesAsync();

            if (repositories.Count() == 0)
                return NoContent();

            return Ok(repositories);

        }
    }
}
