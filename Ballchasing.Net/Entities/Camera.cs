using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Camera
    {

        [DataMember(Name = "fov")]
        public double Fov { get; set; }

        [DataMember(Name = "height")]
        public double Height { get; set; }

        [DataMember(Name = "pitch")]
        public double Pitch { get; set; }

        [DataMember(Name = "distance")]
        public double Distance { get; set; }

        [DataMember(Name = "stiffness")]
        public double Stiffness { get; set; }

        [DataMember(Name = "swivel_speed")]
        public double SwivelSpeed { get; set; }

        [DataMember(Name = "transition_speed")]
        public double TransitionSpeed { get; set; }
    }
}
