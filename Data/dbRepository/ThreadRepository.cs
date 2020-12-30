using System;
using System.Collections.Generic;
using gloryhall.Data.interfaces;
using gloryhall.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace gloryhall.Data.dbRepository
{
    
    public class ThreadRepository : IThread
    {
        private readonly AppDBContent DbData;

        public ThreadRepository(AppDBContent DbContent)
        {
            this.DbData = DbContent;
        }



        public IEnumerable<Thread> GetMatchThreads => DbData.Thread;

    }
}
