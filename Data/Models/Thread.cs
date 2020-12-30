using System;
using System.Collections.Generic;

namespace gloryhall.Data.Models
{
    public class Thread
    {
        public Thread()
        {
        }
        public int id { set; get; }
        public string name { set; get; }
        public DateTime date { set; get; }
        public Match match { set; get; }
        public User user { get; set; }
        public List<Message> messages { set; get; }
    }
}
