using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Stats
    {
        [DataMember(Name = "core")]
        public Core Core { get; set; }

        [DataMember(Name = "boost")]
        public Boost Boost { get; set; }

        [DataMember(Name = "movement")]
        public Movement Movement { get; set; }

        [DataMember(Name = "positioning")]
        public Positioning Positioning { get; set; }

        [DataMember(Name = "demo")]
        public Demo Demo { get; set; }
    }
}
