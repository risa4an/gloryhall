using System;
namespace gloryhall.Data.Models
{
    public class Message
    {
        public Message()
        {
        }
        public int id { set; get; }
        public virtual Thread Thread { set; get; }
        public virtual User User { get; set; }
        public string text { set; get; }

        public DateTime date { set; get; }
    }


}
