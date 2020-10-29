using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MatchResult
    {

        [EnumMember(Value = "win")]
        Win,
        [EnumMember(Value = "loss")]
        Loss


    }
}
