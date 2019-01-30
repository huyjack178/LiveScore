namespace LiveScore.Models
{
    using System;

    public class Match
    {
        public string HomeTeamName { get; set; }

        public string AwayTeamName { get; set; }

        public DateTime EventDate { get; set; }

        public string GroupName { get; set; }

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }
    }
}