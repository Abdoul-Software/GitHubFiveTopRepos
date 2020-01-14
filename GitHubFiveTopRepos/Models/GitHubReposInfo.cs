using System;
using System.Collections.Generic;

namespace GitHubFiveTopRepos.Models
{
    public class GitHubReposInfo
    {
        public int TotalCount { get; set; }
        public bool IncompleteResults { get; set; }
        public List<Item> Items { get; set; }
    }
}
