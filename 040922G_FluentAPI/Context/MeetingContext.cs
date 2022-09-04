using _040922G_FluentAPI.Entity;
using _040922G_FluentAPI.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040922G_FluentAPI.Context
{
    public class MeetingContext : DbContext
    {

        public DbSet<Meeting> MyProperty { get; set; }
        public DbSet<MeetingPlatform> MeetingPlatforms { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public MeetingContext() : base("Server=ASUS\\SQLEXPRESS; Database=MeetingDB; Trusted_Connection=true;")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MeetingContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MeetingMapping());
            modelBuilder.Configurations.Add(new MeetingPlatformMapping());
            modelBuilder.Configurations.Add(new PersonMapping());
            modelBuilder.Configurations.Add(new SubjectMapping());
            modelBuilder.Configurations.Add(new ReportMapping());
        }
    }
}
