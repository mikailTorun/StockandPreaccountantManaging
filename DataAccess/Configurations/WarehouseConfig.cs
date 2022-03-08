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
    public class WarehouseConfig : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> entity)
        {
            //modelBuilder.Entity<Warehouse>(entity =>
            //{
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WarehouseName)
                .IsRequired()
                .HasMaxLength(100);

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.Warehouses)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouses_Firms");
            //});
        }
    }
}
