using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Privacy
    {
        [EnumMember(Value = "privacy")]
        Private,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "unlisted")]
        Unlisted
    }
}
