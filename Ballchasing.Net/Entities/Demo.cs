using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Demo
    {

        [DataMember(Name = "inflicted")]
        public int Inflicted { get; set; }

        [DataMember(Name = "taken")]
        public int Taken { get; set; }
    }
}
