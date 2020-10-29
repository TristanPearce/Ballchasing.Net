using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Movement
    {

        [DataMember(Name = "avg_speed")]
        public int AvgSpeed { get; set; }

        [DataMember(Name = "total_distance")]
        public int TotalDistance { get; set; }

        [DataMember(Name = "time_supersonic_speed")]
        public double TimeSupersonicSpeed { get; set; }

        [DataMember(Name = "time_boost_speed")]
        public double TimeBoostSpeed { get; set; }

        [DataMember(Name = "time_slow_speed")]
        public double TimeSlowSpeed { get; set; }

        [DataMember(Name = "time_ground")]
        public double TimeGround { get; set; }

        [DataMember(Name = "time_low_air")]
        public double TimeLowAir { get; set; }

        [DataMember(Name = "time_high_air")]
        public double TimeHighAir { get; set; }

        [DataMember(Name = "time_powerslide")]
        public double TimePowerslide { get; set; }

        [DataMember(Name = "count_powerslide")]
        public int CountPowerslide { get; set; }

        [DataMember(Name = "avg_powerslide_duration")]
        public double AvgPowerslideDuration { get; set; }

        [DataMember(Name = "avg_speed_percentage")]
        public double AvgSpeedPercentage { get; set; }

        [DataMember(Name = "percent_slow_speed")]
        public double PercentSlowSpeed { get; set; }

        [DataMember(Name = "percent_boost_speed")]
        public double PercentBoostSpeed { get; set; }

        [DataMember(Name = "percent_supersonic_speed")]
        public double PercentSupersonicSpeed { get; set; }

        [DataMember(Name = "percent_ground")]
        public double PercentGround { get; set; }

        [DataMember(Name = "percent_low_air")]
        public double PercentLowAir { get; set; }

        [DataMember(Name = "percent_high_air")]
        public double PercentHighAir { get; set; }
    }
}
