using DataAccess.Configurations;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }

        //public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        //public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new BarcodeConfig());
            modelBuilder.ApplyConfiguration(new FirmConfig());
            modelBuilder.ApplyConfiguration(new StockConfig());
            //modelBuilder.ApplyConfiguration(new UnitConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new WarehouseConfig());
        }
    }
}
