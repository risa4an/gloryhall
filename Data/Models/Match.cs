using System;
namespace gloryhall.Data.Models
{
    public class Match
    {
        public Match()
        {
        }
        public int id { set; get; }
        public string name { set; get; }
        public string category { set; get; }
        public string tournament { set; get; }
        public DateTime date { set; get; }
        public string team1 { set; get; }
        public string team2 { set; get; }
        public sbyte scoresTeam1 { set; get; }
        public sbyte scoresTeam2 { set; get; }
        public string img { set; get; }
    }
}
