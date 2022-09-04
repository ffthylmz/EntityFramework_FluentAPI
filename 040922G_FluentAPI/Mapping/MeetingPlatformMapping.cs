using _040922G_FluentAPI.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040922G_FluentAPI.Mapping
{
    public class MeetingPlatformMapping : EntityTypeConfiguration<MeetingPlatform>
    {
        public MeetingPlatformMapping()
        {
            this.HasKey(a => a.ID);
            this.Property(b => b.Name).HasMaxLength(20).IsRequired();
        }
    }
}
