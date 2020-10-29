using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Team
    {
        [DataMember(Name = "color")]
        public TeamColor Color { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "players")]
        public IList<Player> Players { get; set; }

        [DataMember(Name = "stats")]
        public Stats Stats { get; set; }
    }
}
