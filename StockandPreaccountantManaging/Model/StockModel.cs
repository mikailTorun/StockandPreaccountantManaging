using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockandPreaccountantManaging.Model
{
    public class StockModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Barcode { get; set; }
        public int? WarehouseId { get; set; }
        public double? BuyingPrice { get; set; }
        public double? SellingPrice { get; set; }
        public int FirmId { get; set; }
    }
}
