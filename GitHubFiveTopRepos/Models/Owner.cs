using System;
using System.Buffers;

namespace GitHubFiveTopRepos.Models
{
    public class Owner
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string NodeId { get; set; }
        public string AvatarUrl { get; set; }
        public string GravatarId { get; set; }
        public string Url { get; set; }
        public string ReceivedEventsUrl { get; set; }
        public string Type { get; set; }
    }
}
