using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortBy
    {

        [EnumMember(Value = "replay-date")]
        ReplayDate,

        [EnumMember(Value = "upload-date")]
        UploadDate

    }
}
