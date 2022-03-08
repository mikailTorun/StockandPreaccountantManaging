using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public class FirmController : ControllerBase
    {
        private readonly FirmCrud crud;
        private Firm firm;

        public FirmController(FirmCrud crud, Firm firm)
        {
            this.crud = crud;
            this.firm = firm;
        }

        [HttpGet("{firmID}")]
        public Firm Get(int firmID)
        {
            return crud.GetFirm(firmID);
        }

        [HttpPost]
        public Firm Post([FromBody] FirmModel param)
        {
            Firm saveFirm = new()
            {
                FirmId=param.FirmId,
                Name = param.Name,
                Title = param.Title,
                Adress = param.Adress,
                Mail = param.Mail,
                Phone = param.Phone,
                Vkn = param.Vkn
            };
            int insertedID = crud.InsertFirm(saveFirm);
            Dictionary<string, int> res = new();
            if (insertedID >0)
            {
                res.Add("id",saveFirm.FirmId);
                return saveFirm;
            }
            else
            {
                res.Add("id", 0);
                return saveFirm;
            }
        }

        [HttpPut("{id}")]
        public Firm UpdateFirm(int id,[FromBody] FirmModel firm)
        {
            Firm updateFirm = new()
            {
                FirmId=id,
                Adress = firm.Adress,
                Mail = firm.Mail,
                Name = firm.Name,
                Phone = firm.Phone,
                Title = firm.Title,
                Vkn = firm.Vkn
            };
            Dictionary<string, string> res = new();
            var a = crud.UpdateFirm(updateFirm);

            return crud.GetFirm(id);
            //return new JsonResult(res);// JObject.Parse( JsonConvert.SerializeObject(res["success"]) );
        }

    }
}
