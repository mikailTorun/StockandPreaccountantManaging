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
    public class UnitController : ControllerBase
    {
        private readonly UnitCrud crud;

        public UnitController(UnitCrud crud)
        {
            this.crud = crud;
        }

        //[HttpGet]
        //public List<Unit> Get()
        ////public string Get()
        //{
        //    //return JsonConvert.SerializeObject(crud.GetAllUnit());
        //    //return (crud.GetAllUnit());
        //}


        //[HttpGet("{id}")]
        //public List<Unit> Get(int id)
        //{
        //    //return crud.GetUnit(id);
        //}

        //[HttpPost]
        //public bool Post([FromBody] UnitModel unit)
        //{
        //    //Unit saveUnit = new()
        //    //{
        //    //    UnitType = unit.UnitType
        //    //};
        //    //return crud.InsertUnit(saveUnit);
        //}


        //[HttpPut("{id}")]
        //public bool Put(int id, [FromBody] UnitModel unit)
        //{
        //    //Unit saveUnit = new()
        //    //{
        //    //    UnitId=id,
        //    //    UnitType = unit.UnitType
        //    //};
        //    //return crud.UpdateUnit(saveUnit);
        //}


        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
