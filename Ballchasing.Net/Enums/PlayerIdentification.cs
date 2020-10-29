using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlayerIdentification
    {
        [EnumMember(Value = "by-id")]
        ById,
        [EnumMember(Value = "by-name")]
        ByName
    }
}
