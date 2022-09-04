using _040922G_FluentAPI.Entity;
using System.Collections.Generic;

namespace _040922G_FluentAPI
{
    public class MeetingPlatform
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Meeting> Meetings { get; set; }

        public MeetingPlatform()
        {
            Meetings = new List<Meeting>();
        }
    }
}