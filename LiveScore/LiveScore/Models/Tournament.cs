namespace LiveScore.Models
{
    using System.Collections.Generic;

    public class Tournament
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public IList<Match> Matches { get; set; }
    }
}