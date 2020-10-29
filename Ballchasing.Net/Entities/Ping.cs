using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Ping
    {
        [DataMember(Name = "chaser")]
        public bool Chaser { get; set; }

        [DataMember(Name = "boost")]
        public string Boost { get; set; }

        [DataMember(Name = "ball")]
        public string Ball { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "steam_id")]
        public string SteamId { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "error")]
        public string Error { get; set; }
    }
}
