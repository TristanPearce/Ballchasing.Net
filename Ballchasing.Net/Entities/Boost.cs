using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Boost
    {
        [DataMember(Name = "bpm")]
        public int Bpm { get; set; }

        [DataMember(Name = "bcpm")]
        public double Bcpm { get; set; }

        [DataMember(Name = "avg_amount")]
        public double AvgAmount { get; set; }

        [DataMember(Name = "amount_collected")]
        public int AmountCollected { get; set; }

        [DataMember(Name = "amount_stolen")]
        public int AmountStolen { get; set; }

        [DataMember(Name = "amount_collected_big")]
        public int AmountCollectedBig { get; set; }

        [DataMember(Name = "amount_stolen_big")]
        public int AmountStolenBig { get; set; }

        [DataMember(Name = "amount_collected_small")]
        public int AmountCollectedSmall { get; set; }

        [DataMember(Name = "amount_stolen_small")]
        public int AmountStolenSmall { get; set; }

        [DataMember(Name = "count_collected_big")]
        public int CountCollectedBig { get; set; }

        [DataMember(Name = "count_stolen_big")]
        public int CountStolenBig { get; set; }

        [DataMember(Name = "count_collected_small")]
        public int CountCollectedSmall { get; set; }

        [DataMember(Name = "count_stolen_small")]
        public int CountStolenSmall { get; set; }

        [DataMember(Name = "amount_overfill")]
        public int AmountOverfill { get; set; }

        [DataMember(Name = "amount_overfill_stolen")]
        public int AmountOverfillStolen { get; set; }

        [DataMember(Name = "amount_used_while_supersonic")]
        public int AmountUsedWhileSupersonic { get; set; }

        [DataMember(Name = "time_zero_boost")]
        public double TimeZeroBoost { get; set; }

        [DataMember(Name = "percent_zero_boost")]
        public double PercentZeroBoost { get; set; }

        [DataMember(Name = "time_full_boost")]
        public double TimeFullBoost { get; set; }

        [DataMember(Name = "percent_full_boost")]
        public double PercentFullBoost { get; set; }

        [DataMember(Name = "time_boost_0_25")]
        public double TimeBoost025 { get; set; }

        [DataMember(Name = "time_boost_25_50")]
        public double TimeBoost2550 { get; set; }

        [DataMember(Name = "time_boost_50_75")]
        public double TimeBoost5075 { get; set; }

        [DataMember(Name = "time_boost_75_100")]
        public double TimeBoost75100 { get; set; }

        [DataMember(Name = "percent_boost_0_25")]
        public double PercentBoost025 { get; set; }

        [DataMember(Name = "percent_boost_25_50")]
        public double PercentBoost2550 { get; set; }

        [DataMember(Name = "percent_boost_50_75")]
        public double PercentBoost5075 { get; set; }

        [DataMember(Name = "percent_boost_75_100")]
        public double PercentBoost75100 { get; set; }
    }
}
