using System;
using System.Collections.Generic;
using System.Linq;
using LiveScore.Models;

namespace LiveScore.ViewModels
{
    public class TournamentDetailViewModel : BaseViewModel
    {
        public static List<Match> Matches = new List<Match>
        {
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Round of 16" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Round of 16" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Round of 16" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group A" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group A" },
                 new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group A" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group B" },
                 new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group B" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group C" },
                 new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group C" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group D" },
                 new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group D" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group D" },
                 new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group E" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group E" },
                 new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group E" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group F" },
                 new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group F" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group G" },
                 new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group G" },
                new Match { HomeTeamName = "Manchester United", AwayTeamName = "Chelsea", EventDate = DateTime.Today, GroupName = "Champions League Group H" },
        };

        public static IEnumerable<IGrouping<string, Match>> GroupMatches = Matches.GroupBy(x => x.GroupName);

        public Tournament Item { get; set; }

        public TournamentDetailViewModel(Tournament item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}