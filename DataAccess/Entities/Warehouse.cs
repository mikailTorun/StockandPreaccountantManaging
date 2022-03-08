using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            Stocks = new HashSet<Stock>();
        }

        public int Id { get; set; }
        public int FirmId { get; set; }
        public string Location { get; set; }
        public string WarehouseName { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
