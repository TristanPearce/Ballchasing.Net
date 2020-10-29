using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Positioning
    {

        [DataMember(Name = "avg_distance_to_ball")]
        public int AvgDistanceToBall { get; set; }

        [DataMember(Name = "avg_distance_to_ball_possession")]
        public int AvgDistanceToBallPossession { get; set; }

        [DataMember(Name = "avg_distance_to_ball_no_possession")]
        public int AvgDistanceToBallNoPossession { get; set; }

        [DataMember(Name = "avg_distance_to_mates")]
        public int AvgDistanceToMates { get; set; }

        [DataMember(Name = "time_defensive_third")]
        public double TimeDefensiveThird { get; set; }

        [DataMember(Name = "time_neutral_third")]
        public double TimeNeutralThird { get; set; }

        [DataMember(Name = "time_offensive_third")]
        public double TimeOffensiveThird { get; set; }

        [DataMember(Name = "time_defensive_half")]
        public double TimeDefensiveHalf { get; set; }

        [DataMember(Name = "time_offensive_half")]
        public double TimeOffensiveHalf { get; set; }

        [DataMember(Name = "time_behind_ball")]
        public double TimeBehindBall { get; set; }

        [DataMember(Name = "time_infront_ball")]
        public double TimeInfrontBall { get; set; }

        [DataMember(Name = "time_most_back")]
        public double TimeMostBack { get; set; }

        [DataMember(Name = "time_most_forward")]
        public double TimeMostForward { get; set; }

        [DataMember(Name = "goals_against_while_last_defender")]
        public int GoalsAgainstWhileLastDefender { get; set; }

        [DataMember(Name = "time_closest_to_ball")]
        public double TimeClosestToBall { get; set; }

        [DataMember(Name = "time_farthest_from_ball")]
        public double TimeFarthestFromBall { get; set; }

        [DataMember(Name = "percent_defensive_third")]
        public double PercentDefensiveThird { get; set; }

        [DataMember(Name = "percent_offensive_third")]
        public double PercentOffensiveThird { get; set; }

        [DataMember(Name = "percent_neutral_third")]
        public double PercentNeutralThird { get; set; }

        [DataMember(Name = "percent_defensive_half")]
        public double PercentDefensiveHalf { get; set; }

        [DataMember(Name = "percent_offensive_half")]
        public double PercentOffensiveHalf { get; set; }

        [DataMember(Name = "percent_behind_ball")]
        public double PercentBehindBall { get; set; }

        [DataMember(Name = "percent_infront_ball")]
        public double PercentInfrontBall { get; set; }

        [DataMember(Name = "percent_most_back")]
        public double PercentMostBack { get; set; }

        [DataMember(Name = "percent_most_forward")]
        public double PercentMostForward { get; set; }

        [DataMember(Name = "percent_closest_to_ball")]
        public double PercentClosestToBall { get; set; }

        [DataMember(Name = "percent_farthest_from_ball")]
        public double PercentFarthestFromBall { get; set; }
    }
}
