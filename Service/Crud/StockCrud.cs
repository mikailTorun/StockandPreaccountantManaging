using DataAccess.Data;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Crud
{
    public class StockCrud
    {
        private readonly ApplicationDbContext db;

        public StockCrud(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool InsertStock(Stock stock)
        {
            db.Stocks.Add(stock);
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
        public bool DelStock(Stock stock)
        {
            db.Stocks.Remove(stock);
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
        public bool UpdateStock(Stock stock)
        {
            db.Stocks.Update(stock);
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

        public List<Stock> GetStockList(int firmaID)
        {
            return db.Stocks.Where(x => x.FirmId == firmaID).ToList();
        }        
        public List<Stock> GetStock(int firmaID, int StockID)
        {
            return db.Stocks.Where(x => x.FirmId == firmaID && x.Id == StockID).ToList();
        }
    }
}
