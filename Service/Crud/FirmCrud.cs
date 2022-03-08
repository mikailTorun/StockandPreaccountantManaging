using DataAccess.Data;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Crud
{
    public class FirmCrud
    {
        private readonly ApplicationDbContext db;

        public FirmCrud(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int InsertFirm(Firm firm)
        {
            db.Firms.Add(firm);
            var id = 0;
            try
            {
                id = db.SaveChanges();
            }
            catch(Exception ex)
            {
                return 0;
            }
            return id;
            
        }

        public bool UpdateFirm(Firm firm)
        {
            db.Firms.Update(firm);
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
        public Firm GetFirm(int firmaID)
        {
            return db.Firms.FirstOrDefault(x => x.FirmId == firmaID);
        }
    }
}
