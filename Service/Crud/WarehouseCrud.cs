using DataAccess.Data;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Crud
{
    public class WarehouseCrud
    {
        private readonly ApplicationDbContext db;

        public WarehouseCrud(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool InsertWarehouse(Warehouse wh)
        {
            db.Warehouses.Add(wh);
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
        public bool UpdateWarehouse(Warehouse wh)
        {
            db.Warehouses.Update(wh);
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DeleteWarehouse(Warehouse wh)
        {
            db.Warehouses.Remove(db.Warehouses.Where(x=>x.Id == wh.Id).First());
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

        public Warehouse GetWarehouse(int whID)
        {
            return db.Warehouses.FirstOrDefault(x => x.Id==whID);
        }
        public List<Warehouse> GetAllWarehouse(int frmID)
        {
            return db.Warehouses.Where(x => x.FirmId==frmID).ToList();
            
        }
    }
}
