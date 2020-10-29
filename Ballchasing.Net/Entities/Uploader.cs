using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Uploader
    {

        [DataMember(Name = "steam_id")]
        public string SteamId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "profile_url")]
        public string ProfileUrl { get; set; }

        [DataMember(Name = "avatar")]
        public string Avatar { get; set; }

        [DataMember(Name = "avatar_full")]
        public string AvatarFull { get; set; }

        [DataMember(Name = "avatar_medium")]
        public string AvatarMedium { get; set; }

    }
}
