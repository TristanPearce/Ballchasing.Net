using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TeamColor
    {

        [EnumMember(Value = "blue")]
        Blue,
        [EnumMember(Value = "orange")]
        Orange

    }
}
