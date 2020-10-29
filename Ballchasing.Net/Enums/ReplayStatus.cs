using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReplayStatus
    {
        [EnumMember(Value = "ok")]
        Ok,
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "failed")]
        Failed
    }
}
