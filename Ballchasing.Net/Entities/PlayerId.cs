using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class PlayerId
    {

        [DataMember(Name = "platform")]
        public string Platform { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}
