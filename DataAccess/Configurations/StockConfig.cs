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
    public class StockConfig : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> entity)
        {
            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.BuyingPrice).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.FirmId).HasColumnName("FirmID");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.SellingPrice).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.Barcode).HasMaxLength(50);

            //entity.Property(e => e.UnitId).HasColumnName("UnitID");

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.Firm)
                .WithMany(p => p.Stocks)
                .HasForeignKey(d => d.FirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stocks_Firms");

            //entity.HasOne(d => d.Unit)
            //    .WithMany(p => p.Stocks)
            //    .HasForeignKey(d => d.UnitId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_Stocks_Units");

            entity.HasOne(d => d.Warehouse)
                .WithMany(p => p.Stocks)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_Stocks_Warehouses");
        }
    }
}
