using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockandPreaccountantManaging.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
