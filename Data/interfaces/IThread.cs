using System;
using System.Collections.Generic;
using gloryhall.Data.Models;

namespace gloryhall.Data.interfaces
{
    public interface IThread
    {
        IEnumerable<Thread> GetMatchThreads { get;  }
    }
}
