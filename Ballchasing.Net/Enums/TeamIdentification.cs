using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TeamIdentification
    {
        [EnumMember(Value = "by-distinct-players")]
        ByDistinctPlayers,
        [EnumMember(Value = "by-player-clusters")]
        ByPlayerClusters
    }
}
