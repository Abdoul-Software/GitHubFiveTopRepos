using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GitHubFiveTopRepos.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace GitHubFiveTopRepos
{
    public class GitHubFiveTopReposManager : IGitHubFiveTopReposManager
    {
        private readonly IConfiguration _configuration;

        public GitHubFiveTopReposManager(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<List<Item>> GetGitHubFiveTopReposManager(string language)
        {
            GitHubReposInfo gitHubReposInfo;
            gitHubReposInfo = new GitHubReposInfo();
            HttpClient httpClient = new HttpClient();

            string baseUrl = _configuration.GetConnectionString("GitHubApiUrl");

            httpClient.BaseAddress = new Uri(baseUrl);
            httpClient.DefaultRequestHeaders.Add("User-Agent", "C# Web Service");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            Task<HttpResponseMessage>  httpResponse = httpClient.GetAsync($"{baseUrl}/search/repositories?q=language:{language}&sort=stars&order=desc");

            string payload = await httpResponse.Result.Content.ReadAsStringAsync();

            gitHubReposInfo = JsonConvert.DeserializeObject<GitHubReposInfo>(payload);

            List<Item> GitHubTopFiveRepos = gitHubReposInfo.Items.Take(5).ToList();

            return GitHubTopFiveRepos;
        }
    }
}
