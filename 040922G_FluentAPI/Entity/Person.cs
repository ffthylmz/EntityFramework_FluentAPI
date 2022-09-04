using _040922G_FluentAPI.Entity;
using System.Collections.Generic;

namespace _040922G_FluentAPI
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public List<Meeting> Meetings { get; set; }

        public Person()
        {
            Meetings = new List<Meeting>();
        }
    }
}