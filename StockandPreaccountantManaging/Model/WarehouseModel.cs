using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockandPreaccountantManaging.Model
{
    public class WarehouseModel
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public string Location { get; set; }
        public string WarehouseName { get; set; }
    }
}
