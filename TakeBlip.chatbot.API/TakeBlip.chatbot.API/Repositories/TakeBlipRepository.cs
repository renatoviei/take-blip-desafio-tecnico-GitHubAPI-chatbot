using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TakeBlip.chatbot.API.Entities;

namespace TakeBlip.chatbot.API.Repositories
{
    public class TakeBlipRepository : ITakeBlipRepository
    {
        HttpClient client = new HttpClient();
       
        public TakeBlipRepository()
        {
            client.BaseAddress = new Uri("https://api.github.com/");        

            client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

            client.DefaultRequestHeaders.UserAgent
                .Add(new ProductInfoHeaderValue("take-blip-desafio-tecnico-GitHubAPI-chatbot", "1"));

        }

        public async Task<List<Root>> GetRepositoriesAsync()
        {
            HttpResponseMessage response = await client.GetAsync("orgs/takenet/repos");
           
            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Root>>(dados);
            }
            return new List<Root>();
        }

        public void Dispose()
        {          
            // Encerra conexão com a API
            client.Dispose();
        }

    }
}
