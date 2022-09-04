using _040922G_FluentAPI.Entity;

namespace _040922G_FluentAPI
{
    public class Report
    {
        public int ID { get; set; }

        //Bir rapor bir toplantıya ait olur.

        public int MeetingID { get; set; }
        public Meeting Meeting { get; set; }
    }
}