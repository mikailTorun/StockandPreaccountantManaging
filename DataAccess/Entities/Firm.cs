using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities
{
    public partial class Firm
    {
        public Firm()
        {
            Stocks = new HashSet<Stock>();
            Users = new HashSet<User>();
            Warehouses = new HashSet<Warehouse>();
        }

        public int FirmId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Vkn { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
