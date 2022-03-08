using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities
{
    public partial class Unit
    {
        public Unit()
        {
            //Stocks = new HashSet<Stock>();
        }

        public int UnitId { get; set; }
        public string UnitType { get; set; }

        //public virtual ICollection<Stock> Stocks { get; set; }
    }
}
