using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040922G_FluentAPI.Entity
{
    public class Meeting
    {
        //Entities ;

        public int MeetingID { get; set; }
        public string MeetingName { get; set; }
        public int MeetingTime { get; set; }
        public DateTime MeetingDate { get; set; }
        //Navigation ;

        //Bir toplantıya birden fazla insan katılır.
        public List<Person> People { get; set; }

        //Bir toplantının bir raporu olur.
        public Report Report { get; set; }
        public int ReportID { get; set; }

        //Bir toplantının bir konusu olur
        public Subject Subject { get; set; }
        public int SubjectID { get; set; }

        [ForeignKey("MeetingPlatform")]
        public MeetingPlatform MeetingPlatform { get; set; }
        public int MeetingPlatformID { get; set; }
        public Meeting()
        {
            People = new List<Person>();
            Subject = new Subject();
        }
    }
}
