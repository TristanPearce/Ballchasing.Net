using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class ReplayGroupCreationInfo
    {
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "parent", IsRequired = false)]
        public string Parent { get; set; }

        [DataMember(Name = "player_identification", IsRequired = true)]
        public PlayerIdentification PlayerIdentification { get; set; }

        [DataMember(Name = "team_identification", IsRequired = true)]
        public TeamIdentification TeamIdentification { get; set; }
    }
}
