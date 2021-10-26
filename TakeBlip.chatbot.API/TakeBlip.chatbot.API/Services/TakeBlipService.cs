using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeBlip.chatbot.API.Entities;
using TakeBlip.chatbot.API.Repositories;
using TakeBlip.chatbot.API.ViewModel;

namespace TakeBlip.chatbot.API.Services
{
    public class TakeBlipService : ITakeBlipService
    {
        private readonly ITakeBlipRepository _tbRepository;

        public TakeBlipService(ITakeBlipRepository tbRepository)
        {
            _tbRepository = tbRepository;
        }
        public async Task<List<RootViewModel>> GetRepositoriesAsync()
        {
            var repositories = await _tbRepository.GetRepositoriesAsync();

            var repoList = repositories.Select(repositories => new RootViewModel
            {
                id = repositories.id,
                name = repositories.name,
                description = repositories.description,
                created_at = repositories.created_at,
                language = repositories.language
            })
                .ToList();

            return SortRepoCSharp(repoList);
        }

        public List<RootViewModel> SortRepoCSharp(List<RootViewModel> repoList)
        {
            List<RootViewModel> _repoList = new List<RootViewModel>();
            List<RootViewModel> repoListSort = new List<RootViewModel>();

            IEnumerable<RootViewModel> filteringQuery =
                from repo in repoList
                where repo.language == "C#"
                select repo;

            _repoList = filteringQuery.OrderBy(x => x.created_at).ToList();

            if (_repoList.Count != 0)
            {
             for(short i = 0; i < 5; i++)
                {
                    repoListSort.Add(_repoList[i]);
                }                                   
            }

            return repoListSort;
        }

        public void Dispose()
        {
            _tbRepository?.Dispose();
        }
    }
}
