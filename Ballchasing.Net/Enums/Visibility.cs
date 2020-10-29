using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Visibility
    {


        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "private")]
        Private


    }
}
