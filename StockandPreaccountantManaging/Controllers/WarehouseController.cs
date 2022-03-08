using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
    public class WarehouseController : ControllerBase
    {
        private readonly WarehouseCrud crud;

        public WarehouseController(WarehouseCrud crud)
        {
            this.crud = crud;
        }

        [HttpGet("GetByWhId/{whId}")]
        public string Get(int whId)
        {
            return JsonConvert.SerializeObject(whId);
        }
        [HttpGet("GetByFrmId/{frmId}")]
        public string GetAllWHofFirm(int frmId)
        {
            return JsonConvert.SerializeObject(crud.GetAllWarehouse(frmId));
        }

        [HttpPost]
        public Warehouse Post([FromBody] WarehouseModel wh)
        {
            Warehouse save = new()
            {
                FirmId = wh.FirmId,
                Location = wh.Location,
                WarehouseName = wh.WarehouseName
            };

            crud.InsertWarehouse(save);
            return save;
        }

        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] WarehouseModel wh)
        {
            Warehouse save = new()
            {
                Id = id,
                FirmId = wh.FirmId,
                Location = wh.Location
            };

            return crud.UpdateWarehouse(save);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            Warehouse del = new()
            {
                Id = id,
                FirmId=0,
                Location=""
            };
            return crud.DeleteWarehouse(del);
        }
    }
}
