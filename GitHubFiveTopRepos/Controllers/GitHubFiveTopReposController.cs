using GitHubFiveTopRepos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubFiveTopRepos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitHubFiveTopReposController : ControllerBase
    {
        private readonly IGitHubFiveTopReposManager _manager;

        public GitHubFiveTopReposController(IGitHubFiveTopReposManager manager)
        {
            _manager = manager;
        }

        [HttpGet("{language}")]
        public async Task<List<Item>> Get(string language)
        {
            return await _manager.GetGitHubFiveTopReposManager(language);
        }
    }
}
