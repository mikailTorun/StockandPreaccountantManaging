using DataAccess.Data;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Crud
{
    public class UnitCrud
    {
        private readonly ApplicationDbContext db;

        public UnitCrud(ApplicationDbContext db)
        {
            this.db = db;
        }
        public bool InsertUnit(Unit unit)
        {
            //db.Units.Add(unit);
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
            return true;

        }

        //public bool UpdateUnit(Unit unit)
        //{
        //    //db.Units.Update(unit);
        //    //try
        //    //{
        //    //    db.SaveChanges();
        //    //}
        //    //catch (Exception)
        //    //{
        //    //    return false;
        //    //}
        //    //return true;
        //}

        //public List<Unit> GetUnit(int UnitID)
        //{
        //    return db.Units.Where(x => x.UnitId== UnitID).ToList();
        //}
        //public List<Unit> GetAllUnit()
        //{
        //    return db.Units.ToList();
        //}
    }
}
