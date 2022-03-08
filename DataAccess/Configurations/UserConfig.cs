using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.FirmId).HasColumnName("FirmID");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(e => e.Surname)
                .IsRequired()
                .HasMaxLength(30);

            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(20);

            entity.HasOne(d => d.Firm)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.FirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Firms");
        }
    }
}
