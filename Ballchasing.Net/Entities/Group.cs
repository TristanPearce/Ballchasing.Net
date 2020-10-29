using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Group
    {

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }
    }
}
