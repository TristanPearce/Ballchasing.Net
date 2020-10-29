using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class ReplayGroupLocationInfo
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "link")]
        public string Link { get; set; }
    }
}
