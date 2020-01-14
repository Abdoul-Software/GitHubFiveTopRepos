using System;
using System.Buffers;

namespace GitHubFiveTopRepos.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string NodeId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public Owner Owner { get; set; }
        public bool @Private { get; set; }
        public string HtmlUrl { get; set; }
        public string Description { get; set; }
        public bool Fork { get; set; }
        public string Url { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Pushed_at { get; set; }
        public string Homepage { get; set; }
        public int Size { get; set; }
        public int StargazersCount { get; set; }
        public int WatchersCount { get; set; }
        public string Language { get; set; }
        public int ForksCount { get; set; }
        public int OpenIssuesCount { get; set; }
        public string MasterBranch { get; set; }
        public string DefaultBranch { get; set; }
        public double Score { get; set; }
    }
}
