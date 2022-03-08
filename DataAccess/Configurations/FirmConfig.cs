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
    public class FirmConfig : IEntityTypeConfiguration<Firm>
    {
        public void Configure(EntityTypeBuilder<Firm> entity)
        {
            entity.Property(e => e.FirmId).HasColumnName("FirmID");
            entity.Property(e => e.Vkn).HasMaxLength(11);
            entity.Property(e => e.Adress)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Mail)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Phone).HasMaxLength(13);

            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasIndex(e => e.Vkn).IsUnique();
            entity.Property(e => e.Vkn).HasMaxLength(12);
        }
    }
}
