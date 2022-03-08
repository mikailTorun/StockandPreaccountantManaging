using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Crud;
using StockandPreaccountantManaging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockandPreaccountantManaging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly StockCrud crud;

        public StockController(StockCrud crud)
        {
            this.crud = crud;
        }

        [HttpGet("{FirmId}")]
        public List<Stock> GetAllStockOfFirm(int FirmId)
        {
            return crud.GetStockList(FirmId);
        }

        [HttpGet("{FirmId}/{StockId}")]
        public List<Stock> GetStock(int FirmId, int StockId)
        {
            return crud.GetStock(FirmId, StockId);
        }

        [HttpPost]
        public Stock Post([FromBody] StockModel stock)
        {
            Stock saveStock = new()
            {
                Id=0,
                BuyingPrice = stock.BuyingPrice,
                SellingPrice = stock.SellingPrice,
                Name = stock.Name,
                Title = stock.Title,
                FirmId = stock.FirmId,
                WarehouseId = stock.WarehouseId,
                Barcode = stock.Barcode

            };

            crud.InsertStock(saveStock);
            return saveStock;
        }

        [HttpPost("{id}")]
        public Stock Delete(int id,[FromBody] StockModel stock)
        {

            Stock delStock = new()
            {
                Id = id,
                BuyingPrice = stock.BuyingPrice,
                SellingPrice = stock.SellingPrice,
                Name = stock.Name,
                Title = stock.Title,
                FirmId = stock.FirmId,
                WarehouseId = stock.WarehouseId,
                Barcode = stock.Barcode

            };

            crud.DelStock(delStock);

            return delStock;
        }
    }
}
