using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Player
    {

        [DataMember(Name = "start_time")]
        public double StartTime { get; set; }

        [DataMember(Name = "end_time")]
        public double EndTime { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "id")]
        public PlayerId Id { get; set; }

        [DataMember(Name = "mvp")]
        public bool Mvp { get; set; }

        [DataMember(Name = "car_id")]
        public int CarId { get; set; }

        [DataMember(Name = "car_name")]
        public string CarName { get; set; }

        [DataMember(Name = "camera")]
        public Camera Camera { get; set; }

        [DataMember(Name = "steering_sensitivity")]
        public double SteeringSensitivity { get; set; }

        [DataMember(Name = "stats")]
        public Stats Stats { get; set; }
    }
}
