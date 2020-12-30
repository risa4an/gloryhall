using System;
using Microsoft.AspNetCore.Http;

namespace gloryhall.Data.ViewModels
{
    public class EditMatchViewModel
    {
        public int id { get; set; }
        public string name { get; set; }

        public string team1 { get; set; }
        public string team2 { get; set; }

        public int scoresTeam1 { get; set; }
        public int scoresTeam2 { get; set; }

        
    }

    public class CreateMatchViewModel
    {
        public string name { get; set; }

        public string team1 { get; set; }
        public string team2 { get; set; }

        public int scoresTeam1 { get; set; }
        public int scoresTeam2 { get; set; }
        public IFormFile img { set; get; }
    }

    public class CreateThreadViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
