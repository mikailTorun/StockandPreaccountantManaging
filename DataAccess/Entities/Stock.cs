using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities
{
    public partial class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Barcode { get; set; }
        //public int UnitId { get; set; }
        public int? WarehouseId { get; set; }
        public double? BuyingPrice { get; set; }
        public double? SellingPrice { get; set; }
        public int FirmId { get; set; }
        public virtual Firm Firm { get; set; }
        //public virtual Unit Unit { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
