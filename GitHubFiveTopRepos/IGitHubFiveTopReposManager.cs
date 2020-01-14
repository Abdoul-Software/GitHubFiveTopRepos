using GitHubFiveTopRepos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubFiveTopRepos
{
    public interface IGitHubFiveTopReposManager
    {
        Task<List<Item>> GetGitHubFiveTopReposManager(string language);
    }
}
