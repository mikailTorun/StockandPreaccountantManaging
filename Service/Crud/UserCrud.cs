using DataAccess.Data;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Crud
{
   
    public class UserCrud
    {
        private readonly ApplicationDbContext db;

        public UserCrud(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<User> getUserList(int id)
        {
            return db.Users.Where(x => x.FirmId == id).ToList();
        }
        public bool DeleteUser(User usr)
        {
            db.Users.Remove(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public int InserUser(User user)
        {
            //db.Users.Add(user);
            //db.SaveChanges();
            db.Users.Add(user);
            var id = 0;
            try
            {
                id = db.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
            return id;
        }

        public User GetUser(string username,string pass)
        {
            return db.Users.FirstOrDefault(x => x.Username == username && x.Password==pass);
        }
    }
}
