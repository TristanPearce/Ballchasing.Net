using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ballchasing.Net
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Playlist : ulong
    {


        /// <summary>
        /// Unranked 1 v 1
        /// </summary>
        [EnumMember(Value = "unranked-duels")]
        UnrankedDuels,

        /// <summary>
        /// Unranked 2 v 2
        /// </summary>
        [EnumMember(Value = "unranked-doubles")]
        UnrankedDoubles,

        /// <summary>
        /// Unranked 3 v 3
        /// </summary>
        [EnumMember(Value = "unranked-standard")]
        UnrankedStandard,

        /// <summary>
        /// Unranked 4 v 4
        /// </summary>
        [EnumMember(Value = "unranked-chaos")]
        UnrankedChaos,

        [EnumMember(Value = "private")]
        Private,

        [EnumMember(Value = "season")]
        Season,

        [EnumMember(Value = "offline")]
        Offline,

        [EnumMember(Value = "ranked-duels")]
        RankedDuels,

        [EnumMember(Value = "ranked-doubles")]
        RankedDoubles,

        [EnumMember(Value = "ranked-solo-standard")]
        RankedSoloStandard,

        [EnumMember(Value = "ranked-standard")]
        RankedStandard,

        [EnumMember(Value = "snowday")]
        Snowday,

        // ensure this value is correct
        [EnumMember(Value = "rocketlabs")]
        RocketLabs,

        [EnumMember(Value = "hoops")]
        Hoops,

        [EnumMember(Value = "rumble")]
        Rumble,

        [EnumMember(Value = "tournament")]
        Tournament,

        [EnumMember(Value = "dropshot")]
        Dropshot,

        [EnumMember(Value = "ranked-hoops")]
        RankedHoops,

        [EnumMember(Value = "ranked-rumble")]
        RankedRumble,

        [EnumMember(Value = "ranked-dropshot")]
        RankedDropshot,

        [EnumMember(Value = "ranked-snowday")]
        RankedSnowday,

        [EnumMember(Value = "dropshot-rumble")]
        DropshotRumble,

        // ensure this value is correct
        [EnumMember(Value = "heatseeker")]
        HeatSeeker,
    }
}
