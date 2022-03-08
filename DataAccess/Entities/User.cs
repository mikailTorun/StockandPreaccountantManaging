using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Firm Firm { get; set; }
    }
}
