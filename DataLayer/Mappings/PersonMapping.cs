using Entities.Concrete;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataLayer.Mappings
{
    public class PersonMapping : IEntityTypeConfiguration<PERSON>
    {
        public void Configure(EntityTypeBuilder<PERSON> builder)
        {
            //builder.ToTable("PERSONS");
            builder.HasKey(t => t.ID);
            builder.Property(t => t.NAME).HasMaxLength(255).IsRequired();
            builder.Property(t => t.SURNAME).HasMaxLength(255).IsRequired();
            builder.Property(t => t.BLOOD).IsRequired();
            builder.Property(t => t.PHONENUMBER).HasMaxLength(11).IsRequired();
            builder.Property(t => t.ADDRESS).HasMaxLength(2000).IsRequired();

            builder.HasData(Data());
        }

        IEnumerable<PERSON> Data()
        {
            return new List<PERSON>
            {
                new PERSON()
                {
                    ID = 1,
                    NAME = "İsim",
                    SURNAME = "Soyisim",
                    BLOOD = BloodGroup.bpozotive,
                    PHONENUMBER = "05321234567",
                    ADDRESS = "İstanbul - Üsküdar"
                },
                new PERSON()
                {
                    ID = 2,
                    NAME = "İsim",
                    SURNAME = "Soyisim",
                    BLOOD = BloodGroup.apozotive,
                    PHONENUMBER = "05328901234",
                    ADDRESS = "İstanbul - Ümraniye"
                },
                new PERSON()
                {
                    ID = 3,
                    NAME = "İsim",
                    SURNAME = "Soyisim",
                    BLOOD = BloodGroup.abpozotive,
                    PHONENUMBER = "05325678901",
                    ADDRESS = "İstanbul - Kadıköy"
                }
            };
        }
    }
}
