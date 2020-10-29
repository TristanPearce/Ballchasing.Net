using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Rank : byte
    {

        Unknown,

        [EnumMember(Value = "unranked")]
        Unranked,

        [EnumMember(Value = "bronze-1")]
        Bronze1,

        [EnumMember(Value = "bronze-2")]
        Bronze2,

        [EnumMember(Value = "bronze-3")]
        Bronze3,

        [EnumMember(Value = "silver-1")]
        Silver1,

        [EnumMember(Value = "silver-2")]
        Silver2,

        [EnumMember(Value = "silver-3")]
        Silver3,

        [EnumMember(Value = "gold-1")]
        Gold1,

        [EnumMember(Value = "gold-2")]
        Gold2,

        [EnumMember(Value = "gold-3")]
        Gold3,

        [EnumMember(Value = "platinum-1")]
        Platinum1,

        [EnumMember(Value = "platinum-2")]
        Platinum2,

        [EnumMember(Value = "platinum-3")]
        Platinum3,

        [EnumMember(Value = "diamond-1")]
        Diamond1,

        [EnumMember(Value = "diamond-2")]
        Diamond2,

        [EnumMember(Value = "diamond-3")]
        Diamond3,

        [EnumMember(Value = "champion-1")]
        Champion1,

        [EnumMember(Value = "champion-2")]
        Champion2,

        [EnumMember(Value = "champion-3")]
        Champion3,

        // TODO: CHECK ALL THESE BELOW FOR CORRECTNESS
           /*
        [EnumMember(Value = "grand-champion-1")]
        GrandChampion1,

        [EnumMember(Value = "grand-champion-2")]
        GrandChampion2,

        [EnumMember(Value = "grand-champion-3")]
        GrandChampion3,

        [EnumMember(Value = "supersonic-legend")]
        SupersonicLegend,
                            */
        [EnumMember(Value = "grand-champion")]
        //[Obsolete("The addition of grand champion 1, 2 and 3 have made the plain grand champion rank obsolete. Use GrandChampion1, 2 or 3", error: false)]
        GrandChampion,
    }
}
