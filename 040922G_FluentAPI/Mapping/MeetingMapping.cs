using _040922G_FluentAPI.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040922G_FluentAPI.Mapping
{
    public class MeetingMapping : EntityTypeConfiguration<Meeting>
    {
        public MeetingMapping()
        {
            this.HasKey(a => a.MeetingID);  //PrimaryKey ataması
            this.Property(b => b.MeetingID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(b => b.MeetingName).HasMaxLength(20).IsRequired(); // MeetingName için uzunluğu max 20 karakter ve zorunlu
            this.Property(c => c.MeetingDate).IsRequired();
            this.Property(c => c.MeetingTime).IsRequired();

            //Toplantı ile platform ;
            //Bir toplantı bir platformda yapılır bir platformda birden fazla toplantı yapılır.
            //Bire çok ilişki
            //                     Tek olan kısım              Çok olan kısım               bağlantı prop'u
            this.HasRequired(x => x.MeetingPlatform).WithMany(a => a.Meetings).HasForeignKey(b => b.MeetingPlatformID);

            //Bire Çok ilişki
            //Bir toplantının bir konsu olur bir konuda birden çok toplantı olabilir.
            this.HasRequired(f => f.Subject).WithMany(d => d.Meetings).HasForeignKey(s => s.SubjectID);


            //Bire bir ilişki 
            this.HasOptional(e => e.Report).WithRequired(t => t.Meeting).WillCascadeOnDelete(false);

            //Bir toplantıya birden fazla insan girebilir, bir kişi birden fazla toplantıya girebilir.
            //Çoka çok ilişki
            this.HasMany(a => a.People).WithMany(b => b.Meetings).Map(x =>
                {
                    x.MapLeftKey("PersonID");
                    x.MapRightKey("MeetingID");
                    x.ToTable("MeetingPeople");
                });
        }
    }
}
