using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReplayGroupStatus
    {

        [EnumMember(Value = "ok")]
        Ok,
        [EnumMember(Value = "pending_replays")]
        Pending,
        [EnumMember(Value = "failed_replays")]
        Failed

    }
}
