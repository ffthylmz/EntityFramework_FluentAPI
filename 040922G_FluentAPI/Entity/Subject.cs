using _040922G_FluentAPI.Entity;
using System.Collections.Generic;

namespace _040922G_FluentAPI
{
    public class Subject
    {
        public int ID { get; set; }

        //Bir konuya ait birden fazla toplantı olur.
        public List<Meeting> Meetings { get; set; }

        public Subject()
        {
            Meetings = new List<Meeting>();
        }

    }
}