using System;
using System.Collections.Generic;
using gloryhall.Data.interfaces;
using gloryhall.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace gloryhall.Data.dbRepository
{

    public class MatchRepository : IMatch
    {
        private readonly AppDBContent DbData;

        public MatchRepository(AppDBContent DbContent)
        {
            this.DbData = DbContent;
        }

        public IEnumerable<Match> GetMatches => DbData.Match;
    }
}